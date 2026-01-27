using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.Core;
using Samsara.Net.DriverTrailerAssignments;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.DriverTrailerAssignments;

[TestFixture]
public class CreateDriverTrailerAssignmentTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "driverId": "494123",
              "trailerId": "12345"
            }
            """;

        const string mockResponse = """
            {
              "data": {
                "createdAtTime": "2019-06-13T19:08:25.000Z",
                "driverId": "0987",
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
                    .WithHeader("Content-Type", "application/json")
                    .UsingPost()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.DriverTrailerAssignments.CreateDriverTrailerAssignmentAsync(
            new TrailerAssignmentsCreateDriverTrailerAssignmentRequestBody
            {
                DriverId = "494123",
                TrailerId = "12345",
            }
        );
        Assert.That(
            response,
            Is.EqualTo(
                    JsonUtils.Deserialize<TrailerAssignmentsCreateDriverTrailerAssignmentResponseBody>(
                        mockResponse
                    )
                )
                .UsingDefaults()
        );
    }
}
