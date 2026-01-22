using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.Core;
using Samsara.Net.LegacyApIs;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.LegacyApIs;

[TestFixture]
public class V1GetVehicleHarshEventTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "downloadForwardVideoUrl": "https://samsara-dashcam-videos.s3.us-west-2.amazonaws.com/123/212123456789012/1539201872984/abC123De4-camera-video-segment-123456789.mp4?...",
              "downloadInwardVideoUrl": "https://samsara-dashcam-videos.s3.us-west-2.amazonaws.com/123/212123456789012/1539201872984/abC123De4-camera-video-segment-driver-123456789.mp4?...",
              "downloadTrackedInwardVideoUrl": "https://samsara-dashcam-videos.s3.us-west-2.amazonaws.com/123/212123456789012/1539201872984/abC123De4-camera-video-segment-driver-123456789.tracked.mp4?...",
              "harshEventType": "Harsh Braking",
              "incidentReportUrl": "https://cloud.samsara.com/o/1234/fleet/reports/safety/vehicle/212123456789012/incident/1539201882984",
              "isDistracted": true,
              "location": {
                "address": "350 Rhode Island St, San Francisco, CA",
                "latitude": 33.07614328,
                "longitude": -96.14907287
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/fleet/vehicles/1000000/safety/harsh_event")
                    .WithParam("timestamp", "1000000")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.LegacyApIs.V1GetVehicleHarshEventAsync(
            new V1GetVehicleHarshEventRequest { VehicleId = 1000000, Timestamp = 1000000 }
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<V1VehicleHarshEventResponse>(mockResponse))
                .UsingDefaults()
        );
    }
}
