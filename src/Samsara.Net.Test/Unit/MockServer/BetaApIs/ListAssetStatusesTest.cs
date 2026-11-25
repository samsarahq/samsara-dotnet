using NUnit.Framework;
using Samsara.Net.BetaApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class ListAssetStatusesTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "asset": {
                    "id": "281474976710656"
                  },
                  "comment": "12345",
                  "lastChangedBy": {
                    "actorId": "12345"
                  },
                  "status": {
                    "name": "12345",
                    "statusUuid": "12345"
                  },
                  "statusSinceTime": "2019-06-13T19:08:25Z",
                  "statusUuid": "12345"
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
                    .WithPath("/maintenance/asset-statuses")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.BetaApIs.ListAssetStatusesAsync(new ListAssetStatusesRequest());
        JsonAssert.AreEqual(response, mockResponse);
    }
}
