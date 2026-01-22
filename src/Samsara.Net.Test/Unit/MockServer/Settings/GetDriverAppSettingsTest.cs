using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.Core;
using Samsara.Net.Test.Unit.MockServer;

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
                "gamification": true,
                "gamificationConfig": {
                  "anonymizeDriverNames": true
                },
                "orgVehicleSearch": true,
                "trailerSelection": false,
                "trailerSelectionConfig": {
                  "driverTrailerCreationEnabled": false,
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
        Assert.That(
            response,
            Is.EqualTo(
                    JsonUtils.Deserialize<SettingsGetDriverAppSettingsResponseBody>(mockResponse)
                )
                .UsingDefaults()
        );
    }
}
