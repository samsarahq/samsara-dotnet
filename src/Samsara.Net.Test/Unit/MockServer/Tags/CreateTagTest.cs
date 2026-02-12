using NUnit.Framework;
using Samsara.Net.Tags;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.Tags;

[TestFixture]
public class CreateTagTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "name": "California"
            }
            """;

        const string mockResponse = """
            {
              "data": {
                "addresses": [
                  {
                    "id": "23502866574",
                    "name": "Driver Don"
                  }
                ],
                "assets": [
                  {
                    "id": "23502866574",
                    "name": "Driver Don"
                  }
                ],
                "drivers": [
                  {
                    "id": "23502866574",
                    "name": "Driver Don"
                  }
                ],
                "machines": [
                  {
                    "id": "23502866574",
                    "name": "Driver Don"
                  }
                ],
                "parentTag": {
                  "id": "23502866574",
                  "name": "US West Vehicles"
                },
                "sensors": [
                  {
                    "id": "23502866574",
                    "name": "Driver Don"
                  }
                ],
                "vehicles": [
                  {
                    "id": "23502866574",
                    "name": "Driver Don"
                  }
                ],
                "id": "342417",
                "name": "California",
                "parentTagId": "4815"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/tags")
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

        var response = await Client.Tags.CreateTagAsync(
            new CreateTagRequest { Name = "California" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
