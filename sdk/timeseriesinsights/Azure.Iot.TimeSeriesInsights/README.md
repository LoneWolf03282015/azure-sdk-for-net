# Azure IoT Time Series Insights client library for .NET

This library provides access to the Azure Time Series Insights service.

  [Source code](https://github.com/Azure/azure-sdk-for-net/tree/master/sdk/timeseriesinsights)

## Getting started

The complete Microsoft Azure SDK can be downloaded from the [Microsoft Azure downloads][microsoft_sdk_download] page, and it ships with support for building deployment packages, integrating with tooling, rich command line tooling, and more.

For the best development experience, developers should use the official Microsoft NuGet packages for libraries. NuGet packages are regularly updated with new functionality and hotfixes.

### Install the package

No package has been published for this client library yet.

### Prerequisites

- A Microsoft Azure Subscription
  - To call Microsoft Azure services, create an [Azure subscription][azure_sub].

### Authenticate the Client

In order to interact with the Azure Time Series Insights service, you will need to create an instance of a [TokenCredential class][token_credential] and pass it to the constructor of your [TimeSeriesInsightsClient](https://github.com/Azure/azure-sdk-for-net/blob/master/sdk/timeseriesinsights/Azure.Iot.TimeSeriesInsights/src/TimeSeriesInsightsClient.cs).

## Key concepts

Coming soon.

## Examples

Coming soon.

## Source code folder structure

### /src

The Time Series Insights public client, `TimeSeriesInsightsClient`, and the additional configuration options, `TimeSeriesInsightsClientOptions`, that can be sent to the Time Series Insights service.

### /src/Generated

The code generated by autorest using the swagger file defined in the autorest config file.

To regenerate the code, run the powershell script [generate.ps1](https://github.com/Azure/azure-sdk-for-net/blob/master/sdk/timeseriesinsights/Azure.Iot.TimeSeriesInsights/src/generate.ps1).

Any time the client library code is updated, the following scripts need to be run:

- [Export-AdtApis.ps1](https://github.com/Azure/azure-sdk-for-net/blob/master/sdk/timeseriesinsights/Export-TsiApis.ps1), which will update the [API surface document](https://github.com/Azure/azure-sdk-for-net/blob/master/sdk/timeseriesinsights/Azure.Iot.TimeSeriesInsights/api/Azure.Iot.TimeSeriesInsights.netstandard2.0.cs).
- [Update-Snippets.ps1](https://github.com/Azure/azure-sdk-for-net/blob/master/sdk/timeseriesinsights/Update-TsiSnippets.ps1), which will update all the code snippets in the readme files and in the client documentation comments.

### /src/Customized

The customzied code written to override the following behavior of auto-generated code:

- Declare some of the generated types as **internal**, instead of the autorest default of **public**.

### /src/Models

Model classes useful for use with the Time Series Insights client operations.

### /src/Properties

Assembly properties required for running unit tests.

## Troubleshooting

Coming soon.

## Next steps

See implementation examples with our [code samples](https://github.com/Azure/azure-sdk-for-net/blob/master/sdk/timeseriesinsights/Azure.Iot.TimeSeriesInsights/samples).

## Contributing

This project welcomes contributions and suggestions.
Most contributions require you to agree to a Contributor License Agreement (CLA) declaring that you have the right to, and actually do, grant us the rights to use your contribution.
For details, visit <https://cla.microsoft.com.>

When you submit a pull request, a CLA-bot will automatically determine whether you need to provide a CLA and decorate the PR appropriately (e.g., label, comment).
Simply follow the instructions provided by the bot.
You will only need to do this once across all repos using our CLA.

This project has adopted the [Microsoft Open Source Code of Conduct][code_of_conduct].
For more information see the Code of Conduct FAQ or contact opencode@microsoft.com with any additional questions or comments.

<!-- LINKS -->
[microsoft_sdk_download]: https://azure.microsoft.com/downloads/?sdk=net
[azure_sdk_target_frameworks]: https://github.com/azure/azure-sdk-for-net#target-frameworks
[azure_cli]: https://docs.microsoft.com/cli/azure
[azure_sub]: https://azure.microsoft.com/free/
[package]: https://www.nuget.org/packages/Azure.Iot.TimeSeriesInsights
[code_of_conduct]: https://opensource.microsoft.com/codeofconduct/
[nuget]: https://www.nuget.org/
[azure_portal]: https://portal.azure.com/
[azure_rest_api]: https://docs.microsoft.com/rest/api/azure/
[azure_core_library]: https://github.com/Azure/azure-sdk-for-net/tree/master/sdk/core/Azure.Core
[token_credential]: https://docs.microsoft.com/dotnet/api/azure.core.tokencredential?view=azure-dotnet
[azure_cli]: https://docs.microsoft.com/cli/azure/install-azure-cli?view=azure-cli-latest
[iot_cli_extension]: https://github.com/Azure/azure-iot-cli-extension/releases
[iot_cli_doc]: https://docs.microsoft.com/cli/azure/ext/azure-iot/dt?view=azure-cli-latest
[http_status_code]: https://docs.microsoft.com/dotnet/api/system.net.httpstatuscode?view=netcore-3.1
[tsi_nuget]: https://www.nuget.org/packages/Azure.Iot.TimeSeriesInsights