using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.Core;
using Samsara.Net.Messages;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.Messages;

[TestFixture]
public class V1GetMessagesTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "driverId": 555,
                  "isRead": true,
                  "sender": {
                    "name": "John Doe",
                    "type": "dispatch"
                  },
                  "sentAtMs": 1462881998034,
                  "text": "This is a message."
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock.RequestBuilders.Request.Create().WithPath("/v1/fleet/messages").UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Messages.V1GetMessagesAsync(new V1GetMessagesRequest());
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<InlineResponse2005>(mockResponse)).UsingDefaults()
        );
    }
}
