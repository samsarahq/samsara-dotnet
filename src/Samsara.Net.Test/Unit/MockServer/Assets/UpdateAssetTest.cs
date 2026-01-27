using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.Assets;
using Samsara.Net.Core;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.Assets;

[TestFixture]
public class UpdateAssetTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {}
            """;

        const string mockResponse = """
            {
              "data": {
                "createdAtTime": "2020-01-27T07:06:25.000Z",
                "externalIds": {
                  "key": "value"
                },
                "id": "12345",
                "licensePlate": "XHK1234",
                "make": "Bobcat",
                "model": "S630 T4",
                "name": "MyAsset-1234",
                "notes": "These are notes.",
                "readingsIngestionEnabled": true,
                "regulationMode": "mixed",
                "serialNumber": "LN016251",
                "tags": [
                  {
                    "id": "3914",
                    "name": "East Coast",
                    "parentTagId": "4815"
                  }
                ],
                "type": "uncategorized",
                "updatedAtTime": "2020-01-27T07:06:25.000Z",
                "vin": "1FUJBBCKXCLBZ1234",
                "year": 2015
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/assets")
                    .WithParam("id", "id")
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

        var response = await Client.Assets.UpdateAssetAsync(
            new AssetsUpdateAssetRequestBody { Id = "id" }
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<AssetsUpdateAssetResponseBody>(mockResponse))
                .UsingDefaults()
        );
    }
}
