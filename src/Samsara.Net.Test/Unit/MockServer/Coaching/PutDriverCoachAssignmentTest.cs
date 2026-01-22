using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.Coaching;
using Samsara.Net.Core;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.Coaching;

[TestFixture]
public class PutDriverCoachAssignmentTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": {
                "coachId": "45646",
                "createdAtTime": "2019-06-13T19:08:25.000Z",
                "driverId": "45646",
                "updatedAtTime": "2019-06-13T19:08:25.000Z"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/coaching/driver-coach-assignments")
                    .WithParam("driverId", "driverId")
                    .UsingPut()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Coaching.PutDriverCoachAssignmentAsync(
            new PutDriverCoachAssignmentRequest { DriverId = "driverId" }
        );
        Assert.That(
            response,
            Is.EqualTo(
                    JsonUtils.Deserialize<DriverCoachAssignmentsPutDriverCoachAssignmentResponseBody>(
                        mockResponse
                    )
                )
                .UsingDefaults()
        );
    }
}
