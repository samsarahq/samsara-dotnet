using NUnit.Framework;
using Samsara.Net.BetaApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class ListCarbCtcVehiclesTest : BaseMockServerTest
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
                  "id": "12345",
                  "lastCollectionAtTime": "2024-06-15T08:00:00.000Z",
                  "nextCollectionAtTime": "2024-12-15T00:00:00.000Z",
                  "testStatus": "notScheduled",
                  "testStatusDetails": "Response from CARB CTC: Vehicle PASSED emissions scan."
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
                    .WithPath("/fleet/carb-ctc/vehicles")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.BetaApIs.ListCarbCtcVehiclesAsync(
            new ListCarbCtcVehiclesRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
