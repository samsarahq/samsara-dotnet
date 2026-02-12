using NUnit.Framework;
using Samsara.Net.Media;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

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
                    "availableAtTime": "2019-11-11T14:00:12-04:00",
                    "endTime": "2019-06-13T19:08:25Z",
                    "input": "dashcamForwardFacing",
                    "mediaType": "image",
                    "startTime": "2019-06-13T19:08:25Z",
                    "triggerReason": "api",
                    "urlInfo": {
                      "url": "https://sample.s3.url.com/image.jpeg",
                      "urlExpiryTime": "2019-11-11T14:00:12-04:00"
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
        JsonAssert.AreEqual(response, mockResponse);
    }
}
