using NUnit.Framework;
using Samsara.Net.BetaApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class PatchTechnicianShiftTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "version": 1
            }
            """;

        const string mockResponse = """
            {
              "data": {
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
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/maintenance/technician-shifts")
                    .WithParam("id", "id")
                    .WithHeader("Content-Type", "application/json")
                    .UsingPatch()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.BetaApIs.PatchTechnicianShiftAsync(
            new TechnicianShiftsPatchTechnicianShiftRequestBody { Id = "id", Version = 1 }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
