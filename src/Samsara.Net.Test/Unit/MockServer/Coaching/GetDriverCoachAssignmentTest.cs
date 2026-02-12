using NUnit.Framework;
using Samsara.Net.Coaching;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.Coaching;

[TestFixture]
public class GetDriverCoachAssignmentTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "coachId": "45646",
                  "createdAtTime": "2019-06-13T19:08:25.000Z",
                  "driver": {
                    "driverId": "0987"
                  },
                  "updatedAtTime": "2019-06-13T19:08:25.000Z"
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
                    .WithPath("/coaching/driver-coach-assignments")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Coaching.GetDriverCoachAssignmentAsync(
            new GetDriverCoachAssignmentRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
