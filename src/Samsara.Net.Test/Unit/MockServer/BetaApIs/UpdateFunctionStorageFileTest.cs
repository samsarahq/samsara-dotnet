using NUnit.Framework;
using Samsara.Net.BetaApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class UpdateFunctionStorageFileTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
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
                    .WithParam("name", "name")
                    .UsingPut()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.BetaApIs.UpdateFunctionStorageFileAsync(
            new UpdateFunctionStorageFileRequest { Name = "name" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
