using NUnit.Framework;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;
using Samsara.Net.TrailerAssignments;

namespace Samsara.Net.Test.Unit.MockServer.TrailerAssignments;

[TestFixture]
public class V1GetFleetTrailerAssignmentsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "trailerAssignments": [
                {
                  "driverId": 2047,
                  "endMs": 1462881998034,
                  "startMs": 1462878398034
                }
              ],
              "id": 2041,
              "name": "myTrailer"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/fleet/trailers/1000000/assignments")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.TrailerAssignments.V1GetFleetTrailerAssignmentsAsync(
            new V1GetFleetTrailerAssignmentsRequest { TrailerId = 1000000 }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
