using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.Core;
using Samsara.Net.Media;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.Media;

[TestFixture]
public class ListUploadedMediaTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": {
                "media": [
                  {
                    "availableAtTime": "2019-11-11T18:00:12.000Z",
                    "endTime": "2019-06-13T19:08:25.000Z",
                    "input": "dashcamForwardFacing",
                    "mediaType": "image",
                    "startTime": "2019-06-13T19:08:25.000Z",
                    "triggerReason": "api",
                    "urlInfo": {
                      "url": "https://sample.s3.url.com/image.jpeg",
                      "urlExpiryTime": "2019-11-11T18:00:12.000Z"
                    },
                    "vehicleId": "1234"
                  }
                ]
              },
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
                    .WithPath("/cameras/media")
                    .WithParam("vehicleIds", "vehicleIds")
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

        var response = await Client.Media.ListUploadedMediaAsync(
            new ListUploadedMediaRequest
            {
                VehicleIds = "vehicleIds",
                StartTime = "startTime",
                EndTime = "endTime",
            }
        );
        Assert.That(
            response,
            Is.EqualTo(
                    JsonUtils.Deserialize<MediaRetrievalListUploadedMediaResponseBody>(mockResponse)
                )
                .UsingDefaults()
        );
    }
}
