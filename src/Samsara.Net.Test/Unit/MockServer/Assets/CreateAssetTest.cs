using NUnit.Framework;
using Samsara.Net.Assets;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.Assets;

[TestFixture]
public class CreateAssetTest : BaseMockServerTest
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
                "attributes": [
                  {
                    "dateValues": [
                      "2024-01-15",
                      "2024-12-31"
                    ],
                    "id": "494123",
                    "name": "Compliance/ELD",
                    "numberValues": [
                      867,
                      5309
                    ],
                    "stringValues": [
                      "HQ",
                      "Leased"
                    ]
                  }
                ],
                "createdAtTime": "2020-01-27T07:06:25Z",
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
                "updatedAtTime": "2020-01-27T07:06:25Z",
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

        var response = await Client.Assets.CreateAssetAsync(new AssetsCreateAssetRequestBody());
        JsonAssert.AreEqual(response, mockResponse);
    }
}
