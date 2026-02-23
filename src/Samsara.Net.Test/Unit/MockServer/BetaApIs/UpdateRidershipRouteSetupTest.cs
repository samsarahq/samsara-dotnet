using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.BetaApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class UpdateRidershipRouteSetupTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "accountId": "e4b2c3a5-7d6f-4e8b-9a0c-1b2d3e4f5a6b",
              "passengers": [
                {
                  "passengerId": "a1b2c3d4-5e6f-7a8b-9c0d-1e2f3a4b5c6d"
                }
              ]
            }
            """;

        const string mockResponse = """
            {
              "data": {
                "accountId": "e4b2c3a5-7d6f-4e8b-9a0c-1b2d3e4f5a6b",
                "passengers": [
                  {
                    "dropOffStopId": "790",
                    "passengerId": "a1b2c3d4-5e6f-7a8b-9c0d-1e2f3a4b5c6d",
                    "pickUpStopId": "789"
                  }
                ],
                "routeId": "123456"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/ridership/route-setups")
                    .WithParam("routeId", "routeId")
                    .WithHeader("Content-Type", "application/json")
                    .UsingPut()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.BetaApIs.UpdateRidershipRouteSetupAsync(
            new RidershipRouteSetupsUpdateRidershipRouteSetupRequestBody
            {
                RouteId = "routeId",
                AccountId = "e4b2c3a5-7d6f-4e8b-9a0c-1b2d3e4f5a6b",
                Passengers = new List<RidershipRouteSetupPassengerInputRequestBody>()
                {
                    new RidershipRouteSetupPassengerInputRequestBody
                    {
                        PassengerId = "a1b2c3d4-5e6f-7a8b-9c0d-1e2f3a4b5c6d",
                    },
                },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
