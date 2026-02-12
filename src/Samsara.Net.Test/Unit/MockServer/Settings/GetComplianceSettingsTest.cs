using NUnit.Framework;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

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
                "allowUnregulatedVehiclesEnabled": true,
                "canadaHosEnabled": false,
                "carrierName": "ABC Trucking",
                "dotNumber": 12345678,
                "driverAutoDutyEnabled": false,
                "editCertifiedLogsEnabled": false,
                "forceManualLocationForDutyStatusChangesEnabled": false,
                "forceReviewUnassignedHosEnabled": false,
                "mainOfficeFormattedAddress": "123 Main Street",
                "persistentDutyStatusEnabled": true
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
        JsonAssert.AreEqual(response, mockResponse);
    }
}
