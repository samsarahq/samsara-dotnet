using NUnit.Framework;
using Samsara.Net.BetaApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class ListTimeEntriesTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "activityType": "12345",
                  "clockInAtTime": "2026-07-09T14:10:47.648Z",
                  "clockInLocation": {
                    "latitude": 42.2364884,
                    "longitude": -83.3113959
                  },
                  "clockInSource": "mobile",
                  "clockOutAtTime": "2026-07-09T14:15:47.296Z",
                  "clockOutLocation": {
                    "latitude": 42.2365116,
                    "longitude": -83.3114372
                  },
                  "clockOutMethodType": "manual",
                  "clockOutSource": "mobile",
                  "createdAtTime": "2026-07-09T14:10:48.245Z",
                  "deletedAtTime": "2019-06-13T19:08:25Z",
                  "deletedByUserId": "12345",
                  "hourlyRate": {
                    "amount": "24.50",
                    "currency": "usd"
                  },
                  "id": "85436931-026c-466a-95ae-419a829e3a26",
                  "placeId": "5000000795134",
                  "serviceTaskId": "98e645fa-4b7e-446c-8613-cf2bb0a70727",
                  "timeEntryStatus": "completed",
                  "updatedAtTime": "2026-07-09T14:15:47.820Z",
                  "userId": "590838",
                  "workOrderId": "34"
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
                    .WithPath("/maintenance/time-entries/stream")
                    .WithParam("startTime", "startTime")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.BetaApIs.ListTimeEntriesAsync(
            new ListTimeEntriesRequest { StartTime = "startTime" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
