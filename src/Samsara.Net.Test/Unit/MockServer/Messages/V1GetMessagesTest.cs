using NUnit.Framework;
using Samsara.Net.Messages;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

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
        JsonAssert.AreEqual(response, mockResponse);
    }
}
