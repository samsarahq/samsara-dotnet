using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.Core;
using Samsara.Net.LegacyApIs;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.LegacyApIs;

[TestFixture]
public class GetSafetyEventsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "behaviorLabels": [
                    {
                      "label": "genericTailgating",
                      "name": "Tailgating",
                      "source": "automated"
                    }
                  ],
                  "coachingState": "needsReview",
                  "downloadForwardVideoUrl": "https://s3.console.aws.amazon.com/s3/buckets/samsara-dashcam-videos/21575/212014918400828/1553060687222/huKA7IhpBV-camera-video-segment-1244214895.mp4",
                  "downloadInwardVideoUrl": "https://s3.console.aws.amazon.com/s3/buckets/samsara-dashcam-videos/21575/212014918400828/1553060687222/huKA7IhpBV-camera-video-segment-1244214895.mp4",
                  "downloadTrackedInwardVideoUrl": "https://s3.console.aws.amazon.com/s3/buckets/samsara-dashcam-videos/21575/212014918400828/1553060687222/huKA7IhpBV-camera-video-segment-1244214895.mp4",
                  "driver": {
                    "id": "88668",
                    "name": "Susan Bob"
                  },
                  "id": "212014918174029-1550954461759",
                  "location": {
                    "latitude": 122.142,
                    "longitude": -93.343
                  },
                  "maxAccelerationGForce": 0.123,
                  "time": "2019-06-13T19:08:25.455Z",
                  "vehicle": {
                    "ExternalIds": {
                      "maintenanceId": "250020",
                      "payrollId": "ABFS18600"
                    },
                    "id": "123456789",
                    "name": "Midwest Truck #4"
                  }
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
                    .WithPath("/fleet/safety-events")
                    .WithParam("startTime", "startTime")
                    .WithParam("endTime", "endTime")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.LegacyApIs.GetSafetyEventsAsync(
            new GetSafetyEventsRequest { StartTime = "startTime", EndTime = "endTime" }
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<SafetyEventsListResponse>(mockResponse))
                .UsingDefaults()
        );
    }
}
