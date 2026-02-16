using NUnit.Framework;
using Samsara.Net.Industrial;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.Industrial;

[TestFixture]
public class PatchIndustrialAssetTest : BaseMockServerTest
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
                "customMetadata": {
                  "manufacturer": "Samsara",
                  "serialNumber": "123ABC"
                },
                "dataOutputs": [
                  {
                    "dataGroup": "Control Pressure",
                    "deviceId": "123",
                    "id": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
                    "name": "Digital Output 1"
                  }
                ],
                "id": "123abcde-4567-8910-1112-fghi1314jklm",
                "isRunning": true,
                "location": {
                  "formattedAddress": "350 Rhode Island St, San Francisco CA, 94103",
                  "latitude": 37.765363,
                  "longitude": -122.403098
                },
                "locationDataInput": {
                  "id": "id"
                },
                "locationType": "point",
                "name": "name",
                "parentAsset": {
                  "id": "123abcde-4567-8910-1112-fghi1314jklm",
                  "name": "name"
                },
                "runningStatusDataInput": {
                  "id": "12345"
                },
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
                    .WithPath("/industrial/assets/id")
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

        var response = await Client.Industrial.PatchIndustrialAssetAsync(
            new AssetPatch { Id = "id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
