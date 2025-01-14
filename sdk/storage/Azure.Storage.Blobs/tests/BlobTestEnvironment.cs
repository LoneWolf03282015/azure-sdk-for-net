﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading.Tasks;
using Azure.Storage.Blobs.Specialized;
using Azure.Storage.Test;
using Azure.Storage.Test.Shared;
using NUnit.Framework;

namespace Azure.Storage.Blobs.Tests
{
    public class BlobTestEnvironment : StorageTestEnvironment
    {
        protected override async ValueTask<bool> IsEnvironmentReadyAsync()
        {
            return await DoesOAuthWorkAsync();
        }

        private async Task<bool> DoesOAuthWorkAsync()
        {
            TestContext.Error.WriteLine("Blob Probing OAuth");

            try
            {
                BlobServiceClient serviceClient = new BlobServiceClient(
                    new Uri(TestConfigurations.DefaultTargetOAuthTenant.BlobServiceEndpoint),
                    GetOAuthCredential(TestConfigurations.DefaultTargetOAuthTenant));
                await serviceClient.GetPropertiesAsync();
                var containerName = Guid.NewGuid().ToString();
                var containerClient = serviceClient.GetBlobContainerClient(containerName);
                await containerClient.CreateIfNotExistsAsync();
                try
                {
                    await containerClient.GetPropertiesAsync();
                    var blobName = Guid.NewGuid().ToString();
                    var blobClient = containerClient.GetAppendBlobClient(blobName);
                    await blobClient.CreateIfNotExistsAsync();
                    await blobClient.GetPropertiesAsync();
                }
                finally
                {
                    await containerClient.DeleteIfExistsAsync();
                }
            } catch (RequestFailedException e) when (e.Status == 403 && e.ErrorCode == "AuthorizationPermissionMismatch")
            {
                TestContext.Error.WriteLine("Blob Probing OAuth - not ready");
                return false;
            }
            TestContext.Error.WriteLine("Blob Probing OAuth - ready");
            return true;
        }
    }
}
