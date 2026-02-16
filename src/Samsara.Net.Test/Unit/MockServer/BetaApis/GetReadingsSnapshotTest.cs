using NUnit.Framework;
using Samsara.Net.BetaApis;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApis;

[TestFixture]
public class GetReadingsSnapshotTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "entityId": "123456",
                  "externalIds": {
                    "key": "value"
                  },
                  "happenedAtTime": "2020-01-27T07:06:25Z",
                  "readingId": "engineSpeed",
                  "value": {
                    "key": "value"
                  }
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
                    .WithPath("/readings/latest")
                    .WithParam("readingIds", "readingIds")
                    .WithParam("entityType", "entityType")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.BetaApis.GetReadingsSnapshotAsync(
            new GetReadingsSnapshotRequest { ReadingIds = "readingIds", EntityType = "entityType" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
