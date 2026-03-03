using NUnit.Framework;
using Samsara.Net.BetaApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class ListCarbCtcVehicleHistoryTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "enrollmentId": "550e8400-e29b-41d4-a716-446655440000",
                  "enrollmentVin": "1HGCM82633A123456",
                  "happenedAtTime": "2024-06-15T08:00:00.000Z",
                  "id": "12345",
                  "testResult": "pass",
                  "testResultDetails": "Response from CARB CTC: Vehicle PASSED emissions scan."
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
                    .WithPath("/fleet/carb-ctc/vehicles/history")
                    .WithParam("vehicleIds", "vehicleIds")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.BetaApIs.ListCarbCtcVehicleHistoryAsync(
            new ListCarbCtcVehicleHistoryRequest { VehicleIds = "vehicleIds" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
