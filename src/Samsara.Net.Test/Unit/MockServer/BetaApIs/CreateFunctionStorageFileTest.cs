using NUnit.Framework;
using Samsara.Net.BetaApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class CreateFunctionStorageFileTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "name": "my-script.js"
            }
            """;

        const string mockResponse = """
            {
              "data": {
                "name": "my-script.js",
                "uploadPut": {
                  "expiresAtTime": "2024-01-01T13:00:00.000Z",
                  "url": "https://s3.amazonaws.com/bucket/key?signature=abc123"
                }
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/functions-storage/files")
                    .WithHeader("Content-Type", "application/json")
                    .UsingPost()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.BetaApIs.CreateFunctionStorageFileAsync(
            new FunctionsStorageCreateFunctionStorageFileRequestBody { Name = "my-script.js" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
