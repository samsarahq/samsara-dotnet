using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.Core;
using Samsara.Net.Plans;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.Plans;

[TestFixture]
public class CreateHubPlanTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "hubId": "550e8400-e29b-41d4-a716-446655440000",
              "name": "Weekly Plan - Week 15"
            }
            """;

        const string mockResponse = """
            {
              "data": {
                "createdAt": "2024-04-10T10:30:00.000Z",
                "hubId": "550e8400-e29b-41d4-a716-446655440000",
                "id": "950e8400-e29b-41d4-a716-446655440005",
                "name": "Weekly Plan - Week 15",
                "shiftStartTime": "2024-04-15T09:00:00.000Z",
                "updatedAt": "2024-04-10T10:30:00.000Z"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/hub/plan")
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

        var response = await Client.Plans.CreateHubPlanAsync(
            new HubPlansCreateHubPlanRequestBody
            {
                HubId = "550e8400-e29b-41d4-a716-446655440000",
                Name = "Weekly Plan - Week 15",
            }
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<HubPlansCreateHubPlanResponseBody>(mockResponse))
                .UsingDefaults()
        );
    }
}
