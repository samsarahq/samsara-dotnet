using NUnit.Framework;
using Samsara.Net.Tags;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.Tags;

[TestFixture]
public class ListTagsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
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
              ],
              "pagination": {
                "endCursor": "MjkY",
                "hasNextPage": true
              }
            }
            """;

        Server
            .Given(WireMock.RequestBuilders.Request.Create().WithPath("/tags").UsingGet())
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Tags.ListTagsAsync(new ListTagsRequest());
        JsonAssert.AreEqual(response, mockResponse);
    }
}
