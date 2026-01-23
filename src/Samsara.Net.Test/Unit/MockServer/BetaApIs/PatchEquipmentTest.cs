using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.BetaApIs;
using Samsara.Net.Core;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class PatchEquipmentTest : BaseMockServerTest
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
                "equipmentSerialNumber": "8V8WD530FLN016251",
                "externalIds": {
                  "key": "value"
                },
                "id": "494123",
                "installedGateway": {
                  "model": "AG15",
                  "serial": "GFRV-43N-VGX"
                },
                "name": "Equipment-123",
                "notes": "These are my equipment notes",
                "tags": [
                  {
                    "id": "3914",
                    "name": "East Coast",
                    "parentTagId": "4815"
                  }
                ]
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/beta/fleet/equipment/id")
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

        var response = await Client.BetaApIs.PatchEquipmentAsync(
            new EquipmentPatchEquipmentRequestBody { Id = "id" }
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<EquipmentPatchEquipmentResponseBody>(mockResponse))
                .UsingDefaults()
        );
    }
}
