using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.Assets;
using Samsara.Net.Core;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.Assets;

[TestFixture]
public class V1GetAssetsReefersTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "assetType": "Thermo King",
                  "id": 1,
                  "name": "Reefer 123"
                }
              ],
              "pagination": {
                "endCursor": "MTU5MTEzNjA2OTU0MzQ3",
                "hasNextPage": true,
                "hasPrevPage": true,
                "startCursor": "MTU5MTEzNjA2OTU0MzQ3"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/fleet/assets/reefers")
                    .WithParam("startMs", "1000000")
                    .WithParam("endMs", "1000000")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Assets.V1GetAssetsReefersAsync(
            new V1GetAssetsReefersRequest { StartMs = 1000000, EndMs = 1000000 }
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<InlineResponse2003>(mockResponse)).UsingDefaults()
        );
    }
}
