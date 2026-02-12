using NUnit.Framework;
using Samsara.Net.HoursOfService;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.HoursOfService;

[TestFixture]
public class GetHosLogsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "driver": {
                    "id": "88668",
                    "name": "Susan Bob"
                  },
                  "hosLogs": [
                    {
                      "logEndTime": "2020-01-27T07:06:25Z",
                      "logRecordedLocation": {
                        "latitude": 122.142,
                        "longitude": -93.343
                      },
                      "logStartTime": "2020-01-27T07:06:25Z",
                      "remark": "Lunch Break"
                    }
                  ]
                }
              ],
              "pagination": {
                "endCursor": "MjkY",
                "hasNextPage": true
              }
            }
            """;

        Server
            .Given(WireMock.RequestBuilders.Request.Create().WithPath("/fleet/hos/logs").UsingGet())
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.HoursOfService.GetHosLogsAsync(new GetHosLogsRequest());
        JsonAssert.AreEqual(response, mockResponse);
    }
}
