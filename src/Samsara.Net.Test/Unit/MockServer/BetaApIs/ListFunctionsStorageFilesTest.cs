using NUnit.Framework;
using Samsara.Net.BetaApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class ListFunctionsStorageFilesTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "modifiedAtTime": "2024-01-01T12:00:00.000Z",
                  "name": "my-script.js",
                  "sizeBytes": 1024,
                  "urls": [
                    {
                      "expiresAtTime": "2024-01-01T13:00:00.000Z",
                      "url": "https://s3.amazonaws.com/bucket/key?signature=abc123",
                      "urlType": "download"
                    }
                  ]
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
                    .WithPath("/functions-storage/files")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.BetaApIs.ListFunctionsStorageFilesAsync(
            new ListFunctionsStorageFilesRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
