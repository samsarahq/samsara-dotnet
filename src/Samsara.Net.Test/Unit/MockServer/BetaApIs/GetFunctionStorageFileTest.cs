using NUnit.Framework;
using Samsara.Net.BetaApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class GetFunctionStorageFileTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": {
                "downloadGet": {
                  "expiresAtTime": "2024-01-01T13:00:00.000Z",
                  "url": "https://s3.amazonaws.com/bucket/key?signature=abc123"
                },
                "name": "my-script.js"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/functions-storage/files")
                    .WithParam("name", "name")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.BetaApIs.GetFunctionStorageFileAsync(
            new GetFunctionStorageFileRequest { Name = "name" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
