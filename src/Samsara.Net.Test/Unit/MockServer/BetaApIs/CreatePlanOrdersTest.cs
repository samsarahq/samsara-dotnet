using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.BetaApIs;
using Samsara.Net.Core;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class CreatePlanOrdersTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "data": [
                {
                  "customerOrderId": "ORDER-2024-001",
                  "hubId": "550e8400-e29b-41d4-a716-446655440000",
                  "planId": "650e8400-e29b-41d4-a716-446655440023"
                }
              ]
            }
            """;

        const string mockResponse = """
            {
              "data": [
                {
                  "createdAt": "2024-04-10T11:30:00.000Z",
                  "customProperties": [
                    {
                      "customPropertyId": "750e8400-e29b-41d4-a716-446655440004",
                      "name": "CustomerType",
                      "value": "Premium"
                    }
                  ],
                  "customerOrderId": "ORDER-2024-001",
                  "delivery": {
                    "address": "123 Business Way, San Francisco",
                    "appointmentWindow": {
                      "endTime": "2024-04-10T17:00:00.000Z",
                      "startTime": "2024-04-10T09:00:00.000Z"
                    },
                    "customerLocationId": "LOC-123",
                    "latitude": 37.7749,
                    "longitude": -122.4194,
                    "notes": "Use main entrance",
                    "serviceTimeSeconds": 600
                  },
                  "hubId": "550e8400-e29b-41d4-a716-446655440000",
                  "id": "a50e8400-e29b-41d4-a716-446655440006",
                  "pickup": {
                    "address": "123 Business Way, San Francisco",
                    "appointmentWindow": {
                      "endTime": "2024-04-10T17:00:00.000Z",
                      "startTime": "2024-04-10T09:00:00.000Z"
                    },
                    "customerLocationId": "LOC-123",
                    "latitude": 37.7749,
                    "longitude": -122.4194,
                    "notes": "Use main entrance",
                    "serviceTimeSeconds": 600
                  },
                  "planId": "650e8400-e29b-41d4-a716-446655440023",
                  "priority": 1,
                  "quantities": [
                    {
                      "capacityId": "850e8400-e29b-41d4-a716-446655440003",
                      "quantity": 25.5
                    }
                  ],
                  "skillsRequired": [
                    "650e8400-e29b-41d4-a716-446655440001",
                    "650e8400-e29b-41d4-a716-446655440001"
                  ],
                  "updatedAt": "2024-04-10T11:30:00.000Z"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/hub/plan/orders")
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

        var response = await Client.BetaApIs.CreatePlanOrdersAsync(
            new PlanOrdersCreatePlanOrdersRequestBody
            {
                Data = new List<OrderInputObjectRequestBody>()
                {
                    new OrderInputObjectRequestBody
                    {
                        CustomerOrderId = "ORDER-2024-001",
                        HubId = "550e8400-e29b-41d4-a716-446655440000",
                        PlanId = "650e8400-e29b-41d4-a716-446655440023",
                    },
                },
            }
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<PlanOrdersCreatePlanOrdersResponseBody>(mockResponse))
                .UsingDefaults()
        );
    }
}
