using NUnit.Framework;
using Samsara.Net.BetaApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class ListRidershipAccountsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "createdAtTime": "2024-11-15T10:00:00Z",
                  "externalIds": {
                    "key": "value"
                  },
                  "id": "e4b2c3a5-7d6f-4e8b-9a0c-1b2d3e4f5a6b",
                  "name": "Springfield Public Schools",
                  "updatedAtTime": "2024-11-15T10:30:00Z"
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
                WireMock.RequestBuilders.Request.Create().WithPath("/ridership/accounts").UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.BetaApIs.ListRidershipAccountsAsync(
            new ListRidershipAccountsRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
