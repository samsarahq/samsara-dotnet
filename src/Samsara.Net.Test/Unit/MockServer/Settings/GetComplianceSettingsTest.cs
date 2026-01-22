using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.Core;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.Settings;

[TestFixture]
public class GetComplianceSettingsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": {
                "allowUnregulatedVehiclesEnabled": false,
                "canadaHosEnabled": false,
                "carrierName": "ABC Trucking",
                "dotNumber": 12345678,
                "driverAutoDutyEnabled": false,
                "editCertifiedLogsEnabled": false,
                "forceManualLocationForDutyStatusChangesEnabled": false,
                "forceReviewUnassignedHosEnabled": true,
                "mainOfficeFormattedAddress": "123 Main Street",
                "persistentDutyStatusEnabled": false
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/fleet/settings/compliance")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Settings.GetComplianceSettingsAsync();
        Assert.That(
            response,
            Is.EqualTo(
                    JsonUtils.Deserialize<SettingsGetComplianceSettingsResponseBody>(mockResponse)
                )
                .UsingDefaults()
        );
    }
}
