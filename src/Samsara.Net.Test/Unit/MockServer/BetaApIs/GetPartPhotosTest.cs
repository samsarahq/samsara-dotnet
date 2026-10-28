using NUnit.Framework;
using Samsara.Net.BetaApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class GetPartPhotosTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": {
                "partId": "4c6d8f2e-9b1a-4e3f-8a7b-2d5c6e9f0a1b",
                "photos": [
                  {
                    "id": "9814a1fa-f0c6-408b-bf85-51dc3bc71ac7",
                    "processingStatus": "unknown",
                    "url": "https://samsara-media.s3.us-west-2.amazonaws.com/123456",
                    "urlExpiresAtTime": "2019-06-13T19:08:25.000Z"
                  }
                ],
                "profilePhoto": {
                  "id": "9814a1fa-f0c6-408b-bf85-51dc3bc71ac7",
                  "processingStatus": "unknown",
                  "url": "https://samsara-media.s3.us-west-2.amazonaws.com/123456",
                  "urlExpiresAtTime": "2019-06-13T19:08:25.000Z"
                }
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/maintenance/parts/photos")
                    .WithParam("partId", "partId")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.BetaApIs.GetPartPhotosAsync(
            new GetPartPhotosRequest { PartId = "partId" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
