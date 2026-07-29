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
                  "clockInAtTime": "2019-06-13T19:08:25Z",
                  "clockInLocation": {
                    "latitude": 123.45,
                    "longitude": 123.45
                  },
                  "clockInSource": "12345",
                  "clockOutAtTime": "2019-06-13T19:08:25Z",
                  "clockOutLocation": {
                    "latitude": 123.45,
                    "longitude": 123.45
                  },
                  "clockOutMethodType": "12345",
                  "clockOutSource": "12345",
                  "createdAtTime": "2019-06-13T19:08:25Z",
                  "deletedAtTime": "2019-06-13T19:08:25Z",
                  "deletedByUserId": "12345",
                  "hourlyRate": {
                    "amount": "12345",
                    "currency": "12345"
                  },
                  "id": "12345",
                  "placeId": "12345",
                  "serviceTaskId": "12345",
                  "timeEntryStatus": "12345",
                  "updatedAtTime": "2019-06-13T19:08:25Z",
                  "userId": "12345",
                  "workOrderId": "12345"
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
