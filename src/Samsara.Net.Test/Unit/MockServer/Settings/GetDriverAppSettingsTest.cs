using NUnit.Framework;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.Settings;

[TestFixture]
public class GetDriverAppSettingsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": {
                "driverFleetId": "abc_trucking_co",
                "gamification": false,
                "gamificationConfig": {
                  "anonymizeDriverNames": true
                },
                "orgVehicleSearch": true,
                "trailerSelection": false,
                "trailerSelectionConfig": {
                  "driverTrailerCreationEnabled": true,
                  "maxNumOfTrailersSelected": 1000000,
                  "orgTrailerSearch": false
                }
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/fleet/settings/driver-app")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Settings.GetDriverAppSettingsAsync();
        JsonAssert.AreEqual(response, mockResponse);
    }
}
