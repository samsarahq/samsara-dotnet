using NUnit.Framework;
using Samsara.Net.DriverTrailerAssignments;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.DriverTrailerAssignments;

[TestFixture]
public class GetDriverTrailerAssignmentsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "createdAtTime": "createdAtTime",
                  "driver": {
                    "driverId": "driverId",
                    "externalIds": {
                      "externalIds": "externalIds"
                    }
                  },
                  "endTime": "endTime",
                  "id": "id",
                  "startTime": "startTime",
                  "trailer": {
                    "trailerId": "trailerId"
                  },
                  "updatedAtTime": "updatedAtTime"
                },
                {
                  "createdAtTime": "createdAtTime",
                  "driver": {
                    "driverId": "driverId",
                    "externalIds": {
                      "externalIds": "externalIds"
                    }
                  },
                  "endTime": "endTime",
                  "id": "id",
                  "startTime": "startTime",
                  "trailer": {
                    "trailerId": "trailerId"
                  },
                  "updatedAtTime": "updatedAtTime"
                }
              ],
              "pagination": {
                "endCursor": "endCursor",
                "hasNextPage": true
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/driver-trailer-assignments")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.DriverTrailerAssignments.GetDriverTrailerAssignmentsAsync(
            new GetDriverTrailerAssignmentsRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
