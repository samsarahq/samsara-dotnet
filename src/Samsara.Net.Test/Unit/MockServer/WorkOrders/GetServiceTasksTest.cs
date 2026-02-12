using NUnit.Framework;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;
using Samsara.Net.WorkOrders;

namespace Samsara.Net.Test.Unit.MockServer.WorkOrders;

[TestFixture]
public class GetServiceTasksTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "category": "Engine",
                  "description": "Standard oil change service including filter replacement.",
                  "estimatedLaborTimeMinutes": 30,
                  "estimatedPartsCost": {
                    "amount": "94.01",
                    "currency": "usd"
                  },
                  "id": "abf63a9a-4d75-423d-b49f-38a071e6ce36",
                  "name": "Oil Change",
                  "subcategory": "Oil and Lubrication"
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
                    .WithPath("/maintenance/service-tasks")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.WorkOrders.GetServiceTasksAsync(new GetServiceTasksRequest());
        JsonAssert.AreEqual(response, mockResponse);
    }
}
