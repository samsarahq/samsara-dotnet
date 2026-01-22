using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.Assets;
using Samsara.Net.Core;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.Assets;

[TestFixture]
public class V1GetAssetReeferTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "assetType": "Thermo King",
              "id": 1,
              "name": "Reefer 123",
              "reeferStats": {
                "alarms": [
                  {
                    "changedAtMs": 1453449599999
                  }
                ],
                "engineHours": [
                  {
                    "changedAtMs": 1453449599999,
                    "engineHours": 1200
                  }
                ],
                "fuelPercentage": [
                  {
                    "changedAtMs": 1453449599999,
                    "fuelPercentage": 99
                  }
                ],
                "powerStatus": [
                  {
                    "changedAtMs": 1453449599999,
                    "status": "Active (Continuous)"
                  }
                ],
                "returnAirTemp": [
                  {
                    "changedAtMs": 1453449599999,
                    "tempInMilliC": 31110
                  }
                ],
                "setPoint": [
                  {
                    "changedAtMs": 1453449599999,
                    "tempInMilliC": 31110
                  }
                ]
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/fleet/assets/1000000/reefer")
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

        var response = await Client.Assets.V1GetAssetReeferAsync(
            new V1GetAssetReeferRequest
            {
                AssetId = 1000000,
                StartMs = 1000000,
                EndMs = 1000000,
            }
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<V1AssetReeferResponse>(mockResponse)).UsingDefaults()
        );
    }
}
