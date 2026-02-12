using NUnit.Framework;
using Samsara.Net.BetaApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class GetDetectionsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "asset": {
                    "id": "asset-23ab7cd1-5f6e-4c9b-8f21-1e3b7a9c4d8f",
                    "name": "Truck 102 - Volvo VNL",
                    "tags": [
                      {
                        "id": "3914",
                        "name": "East Coast",
                        "parentTagId": "4815"
                      }
                    ]
                  },
                  "createdAtTime": "2025-09-20T11:15:30Z",
                  "driver": {
                    "id": "driver-8b12fa3d-3c6e-4e2a-9a76-24c1f7b23d9a",
                    "name": "Alex Johnson",
                    "tags": [
                      {
                        "id": "3914",
                        "name": "East Coast",
                        "parentTagId": "4815"
                      }
                    ]
                  },
                  "id": "9c4f81d2-7a25-4f8c-9b83-1c34a91e34a1",
                  "inCabAlertPlayed": true,
                  "safetyEvent": [
                    {
                      "id": "a1b2c3d4-5678-90ab-cdef-1234567890ab",
                      "inboxEvent": false
                    }
                  ],
                  "triggerDetectionLabel": "acceleration",
                  "updatedAtTime": "2025-09-20T11:20:45Z"
                }
              ],
              "pagination": {
                "endCursor": "MjkY",
                "hasNextPage": true
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/detections/stream")
                    .WithParam("startTime", "startTime")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.BetaApIs.GetDetectionsAsync(
            new GetDetectionsRequest { StartTime = "startTime" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
