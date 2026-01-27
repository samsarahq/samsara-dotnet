using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.Core;
using Samsara.Net.Industrial;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.Industrial;

[TestFixture]
public class GetDataInputDataFeedTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "fftSpectraPoints": [
                    {
                      "time": "2020-01-27T07:06:25.000Z"
                    }
                  ],
                  "j1939D1StatusPoints": [
                    {
                      "time": "2020-01-27T07:06:25.000Z"
                    }
                  ],
                  "locationPoints": [
                    {
                      "time": "2020-01-27T07:06:25.000Z"
                    }
                  ],
                  "numberPoints": [
                    {
                      "time": "2020-01-27T07:06:25.000Z",
                      "value": 1992.0506
                    }
                  ],
                  "stringPoints": [
                    {
                      "time": "2020-01-27T07:06:25.000Z",
                      "value": "On"
                    }
                  ],
                  "assetId": "74771078-5edb-4733-88f2-7242f520d1f1",
                  "dataGroup": "Flow",
                  "id": "id",
                  "name": "Pump Flow",
                  "units": "Gallons Per Minute"
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
                    .WithPath("/industrial/data-inputs/data-points/feed")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Industrial.GetDataInputDataFeedAsync(
            new GetDataInputDataFeedRequest()
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<DataInputListResponse>(mockResponse)).UsingDefaults()
        );
    }
}
