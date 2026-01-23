using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.Core;
using Samsara.Net.Media;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.Media;

[TestFixture]
public class GetMediaRetrievalTest : BaseMockServerTest
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
                    "input": "dashcamDriverFacing",
                    "mediaType": "image",
                    "startTime": "2019-06-13T19:08:25.000Z",
                    "status": "available",
                    "urlInfo": {
                      "url": "https://sample.s3.url.com/image.jpeg",
                      "urlExpiryTime": "2019-11-11T18:00:12.000Z"
                    },
                    "vehicleId": "1234"
                  }
                ]
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/cameras/media/retrieval")
                    .WithParam("retrievalId", "retrievalId")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Media.GetMediaRetrievalAsync(
            new GetMediaRetrievalRequest { RetrievalId = "retrievalId" }
        );
        Assert.That(
            response,
            Is.EqualTo(
                    JsonUtils.Deserialize<MediaRetrievalGetMediaRetrievalResponseBody>(mockResponse)
                )
                .UsingDefaults()
        );
    }
}
