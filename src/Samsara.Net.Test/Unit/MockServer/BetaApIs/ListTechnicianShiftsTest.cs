using NUnit.Framework;
using Samsara.Net.BetaApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class ListTechnicianShiftsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "clockInAtTime": "2026-09-10T15:00:00.000Z",
                  "clockInSource": "api",
                  "clockOutAtTime": "2026-09-10T15:00:00.000Z",
                  "clockOutSource": "api",
                  "createdAtTime": "2026-09-10T15:00:00.000Z",
                  "driverId": "281474976710657",
                  "externalIds": {
                    "hrisShiftId": "SHIFT-9001"
                  },
                  "externalTechnicianIds": {
                    "hrisShiftId": "SHIFT-9001"
                  },
                  "id": "27df219c-2e98-4c4d-9c1f-11dfe40f46ed",
                  "placeId": "281474976710658",
                  "status": "inProgress",
                  "updatedAtTime": "2026-09-10T15:00:00.000Z",
                  "userId": "281474976710656",
                  "version": 1
                }
              ],
              "pagination": {
                "endCursor": "",
                "hasNextPage": false
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/maintenance/technician-shifts")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.BetaApIs.ListTechnicianShiftsAsync(
            new ListTechnicianShiftsRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
