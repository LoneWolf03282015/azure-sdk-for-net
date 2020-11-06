// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Avs.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// An update of a cluster resource
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ClusterUpdate
    {
        /// <summary>
        /// Initializes a new instance of the ClusterUpdate class.
        /// </summary>
        public ClusterUpdate()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ClusterUpdate class.
        /// </summary>
        /// <param name="clusterSize">The cluster size</param>
        public ClusterUpdate(int? clusterSize = default(int?))
        {
            ClusterSize = clusterSize;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the cluster size
        /// </summary>
        [JsonProperty(PropertyName = "properties.clusterSize")]
        public int? ClusterSize { get; set; }

    }
}