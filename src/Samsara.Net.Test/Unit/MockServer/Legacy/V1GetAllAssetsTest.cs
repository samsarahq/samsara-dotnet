using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.Core;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.Legacy;

[TestFixture]
public class V1GetAllAssetsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "assets": [
                {
                  "assetSerialNumber": "SNTEST123",
                  "cable": {
                    "assetType": "Thermo King"
                  },
                  "engineHours": 104,
                  "id": 1,
                  "name": "Trailer 123",
                  "vehicleId": 2
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock.RequestBuilders.Request.Create().WithPath("/v1/fleet/assets").UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Legacy.V1GetAllAssetsAsync();
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<InlineResponse2001>(mockResponse)).UsingDefaults()
        );
    }
}
