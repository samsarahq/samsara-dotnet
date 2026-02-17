using NUnit.Framework;
using Samsara.Net.Assets;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.Assets;

[TestFixture]
public class V1GetAssetLocationTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            [
              {
                "latitude": 37,
                "location": "525 York, San Francisco, CA",
                "longitude": -122.7,
                "speedMilesPerHour": 35,
                "time": 12314151
              }
            ]
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/fleet/assets/1000000/locations")
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

        var response = await Client.Assets.V1GetAssetLocationAsync(
            new V1GetAssetLocationRequest
            {
                AssetId = 1000000,
                StartMs = 1000000,
                EndMs = 1000000,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
