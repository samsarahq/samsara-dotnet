using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.Core;
using Samsara.Net.Safety;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.Safety;

[TestFixture]
public class GetSafetyEventsV2StreamTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "asset": {
                    "id": "bb2ff5ab-30ad-49ec-9d2d-55ec30bbf590,6caeb9c0-7e3d-49ae-a015-45c2f68fed4c",
                    "name": "MyAsset-1234",
                    "tags": [
                      {
                        "id": "3914",
                        "name": "East Coast",
                        "parentTagId": "4815"
                      }
                    ],
                    "vin": "1GBJ6P1B2HV112765"
                  },
                  "assignedCoach": "0987",
                  "behaviorLabels": [
                    {}
                  ],
                  "contextLabels": [
                    {
                      "authorId": "1234",
                      "createdAtTime": "2023-01-27T07:06:25.000Z",
                      "name": "Moderate Traffic"
                    }
                  ],
                  "createdAtTime": "2023-01-27T07:06:25.000Z",
                  "detectedStreams": [
                    {
                      "auxcamSerial": "ABC123",
                      "input": "dashcamRoadFacing",
                      "url": "https://samsara-driver-media-upload.s3.us-west-2.amazonaws.com/123456"
                    }
                  ],
                  "dismissalReason": {
                    "comment": "minorEvent"
                  },
                  "driver": {
                    "id": "0987",
                    "name": "Driver Name",
                    "tags": [
                      {
                        "id": "3914",
                        "name": "East Coast",
                        "parentTagId": "4815"
                      }
                    ]
                  },
                  "endMs": "2023-01-27T07:06:25.000Z",
                  "eventState": "unknown",
                  "id": "bb2ff5ab-30ad-49ec-9d2d-55ec30bbf590,6caeb9c0-7e3d-49ae-a015-45c2f68fed4c",
                  "inboxEventUrl": "https://cloud.samsara.com/",
                  "incidentReportUrl": "https://cloud.samsara.com/",
                  "location": {
                    "accuracyMeters": 5.801,
                    "headingDegrees": 120,
                    "latitude": 37.7749,
                    "longitude": 137.2719
                  },
                  "maxAccelerationGForce": 1,
                  "media": [
                    {
                      "auxcamSerial": "ABC123",
                      "input": "dashcamRoadFacing",
                      "url": "https://samsara-driver-media-upload.s3.us-west-2.amazonaws.com/123456"
                    }
                  ],
                  "speedingMetadata": {
                    "maxSpeedKilometersPerHour": 3727253109057410600,
                    "postedSpeedLimitKilometersPerHour": 7584398116194781000
                  },
                  "startMs": "2023-01-27T07:01:25.000Z",
                  "tripEndTime": "2023-01-27T07:06:25.000Z",
                  "tripStartTime": "2023-01-27T07:06:25.000Z",
                  "updatedAtTime": "2023-01-27T10:04:20.000Z",
                  "updatedByUserId": "0987"
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
                    .WithPath("/safety-events/stream")
                    .WithParam("startTime", "startTime")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Safety.GetSafetyEventsV2StreamAsync(
            new GetSafetyEventsV2StreamRequest { StartTime = "startTime" }
        );
        Assert.That(
            response,
            Is.EqualTo(
                    JsonUtils.Deserialize<SafetyEventsV2GetSafetyEventsV2StreamResponseBody>(
                        mockResponse
                    )
                )
                .UsingDefaults()
        );
    }
}
