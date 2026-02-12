using NUnit.Framework;
using Samsara.Net.Media;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

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
                    "availableAtTime": "2019-11-11T14:00:12-04:00",
                    "endTime": "2019-06-13T19:08:25Z",
                    "input": "dashcamDriverFacing",
                    "mediaType": "image",
                    "startTime": "2019-06-13T19:08:25Z",
                    "status": "available",
                    "urlInfo": {
                      "url": "https://sample.s3.url.com/image.jpeg",
                      "urlExpiryTime": "2019-11-11T14:00:12-04:00"
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
        JsonAssert.AreEqual(response, mockResponse);
    }
}
