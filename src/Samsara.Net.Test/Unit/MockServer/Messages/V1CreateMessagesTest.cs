using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.Core;
using Samsara.Net.Messages;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.Messages;

[TestFixture]
public class V1CreateMessagesTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "driverIds": [
                111,
                222,
                333
              ],
              "text": "This is a message."
            }
            """;

        const string mockResponse = """
            {
              "data": [
                {
                  "driverId": 555,
                  "text": "This is a message."
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/fleet/messages")
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

        var response = await Client.Messages.V1CreateMessagesAsync(
            new InlineObject2
            {
                DriverIds = new List<long>() { 111, 222, 333 },
                Text = "This is a message.",
            }
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<InlineResponse2006>(mockResponse)).UsingDefaults()
        );
    }
}
