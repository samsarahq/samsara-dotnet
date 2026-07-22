using NUnit.Framework;
using Samsara.Net.Assets;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.Assets;

[TestFixture]
public class GetAssetLocationTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "locations": [
                {
                  "latitude": 37,
                  "location": "525 York, San Francisco, CA",
                  "longitude": -122.7,
                  "speedMilesPerHour": 35,
                  "time": 12314151
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/fleet/assets/1000000/locations")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Assets.GetAssetLocationAsync(
            new GetAssetLocationRequest { AssetId = 1000000 }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
