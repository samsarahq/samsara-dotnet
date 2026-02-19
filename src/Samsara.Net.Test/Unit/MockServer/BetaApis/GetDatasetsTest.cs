using NUnit.Framework;
using Samsara.Net.BetaApis;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApis;

[TestFixture]
public class GetDatasetsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "displayName": "Assets",
                  "fields": [
                    {
                      "dataType": "string",
                      "displayName": "Asset: Name",
                      "name": "Name"
                    }
                  ],
                  "hasTimeRangeFilter": true,
                  "id": "Assets",
                  "timeRangeLimitDays": 31
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
                WireMock.RequestBuilders.Request.Create().WithPath("/reports/datasets").UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.BetaApis.GetDatasetsAsync(new GetDatasetsRequest());
        JsonAssert.AreEqual(response, mockResponse);
    }
}
