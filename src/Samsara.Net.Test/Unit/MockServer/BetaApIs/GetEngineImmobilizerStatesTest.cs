using NUnit.Framework;
using Samsara.Net.BetaApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class GetEngineImmobilizerStatesTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "happenedAtTime": "2019-06-13T19:08:25Z",
                  "isConnectedToVehicle": false,
                  "relayStates": [
                    {
                      "id": "relay1",
                      "isOpen": false
                    }
                  ],
                  "vehicleId": "1234"
                }
              ],
              "pagination": {
                "endCursor": "MjkY",
                "hasNextPage": true
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/fleet/vehicles/immobilizer/stream")
                    .WithParam("vehicleIds", "vehicleIds")
                    .WithParam("startTime", "startTime")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.BetaApIs.GetEngineImmobilizerStatesAsync(
            new GetEngineImmobilizerStatesRequest
            {
                VehicleIds = "vehicleIds",
                StartTime = "startTime",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
