using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.Core;
using Samsara.Net.Industrial;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.Industrial;

[TestFixture]
public class PatchAssetDataOutputsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "values": {
                "key": "value"
              }
            }
            """;

        const string mockResponse = """
            {
              "data": [
                {
                  "errorMessage": "Failed to write to Device: GFRV-43N-VGX",
                  "id": "8a9371af-82d1-4158-bf91-4ecc8d3a114c",
                  "statusCode": 200
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/industrial/assets/id/data-outputs")
                    .WithHeader("Content-Type", "application/json")
                    .UsingPatch()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Industrial.PatchAssetDataOutputsAsync(
            new AssetDataOutputsPatchAssetDataOutputsRequestBody
            {
                Id = "id",
                Values = new Dictionary<string, object?>() { { "key", "value" } },
            }
        );
        Assert.That(
            response,
            Is.EqualTo(
                    JsonUtils.Deserialize<AssetDataOutputsPatchAssetDataOutputsResponseBody>(
                        mockResponse
                    )
                )
                .UsingDefaults()
        );
    }
}
