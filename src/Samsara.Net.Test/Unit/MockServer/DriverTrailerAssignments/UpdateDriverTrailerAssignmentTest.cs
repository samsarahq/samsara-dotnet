using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.Core;
using Samsara.Net.DriverTrailerAssignments;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.DriverTrailerAssignments;

[TestFixture]
public class UpdateDriverTrailerAssignmentTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "endTime": "2019-06-13T19:08:25.000Z"
            }
            """;

        const string mockResponse = """
            {
              "data": {
                "createdAtTime": "2019-06-13T19:08:25.000Z",
                "driverId": "0987",
                "endTime": "2019-06-13T19:08:25.000Z",
                "id": "08b3aeada5f4ab3010c0b4efa28d2d1890dbf8d48d2d6",
                "startTime": "2019-06-13T19:08:25.000Z",
                "trailerId": "494123",
                "updatedAtTime": "2019-06-13T19:08:25.000Z"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/driver-trailer-assignments")
                    .WithParam("id", "id")
                    .WithHeader("Content-Type", "application/json")
                    .UsingPatch()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.DriverTrailerAssignments.UpdateDriverTrailerAssignmentAsync(
            new TrailerAssignmentsUpdateDriverTrailerAssignmentRequestBody
            {
                Id = "id",
                EndTime = "2019-06-13T19:08:25Z",
            }
        );
        Assert.That(
            response,
            Is.EqualTo(
                    JsonUtils.Deserialize<TrailerAssignmentsUpdateDriverTrailerAssignmentResponseBody>(
                        mockResponse
                    )
                )
                .UsingDefaults()
        );
    }
}
