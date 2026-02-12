using NUnit.Framework;
using Samsara.Net.HoursOfService;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.HoursOfService;

[TestFixture]
public class GetHosClocksTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "currentVehicle": {
                    "ExternalIds": {
                      "maintenanceId": "250020",
                      "payrollId": "ABFS18600"
                    },
                    "id": "123456789",
                    "name": "Midwest Truck #4"
                  },
                  "driver": {
                    "id": "88668",
                    "name": "Susan Bob"
                  },
                  "violations": {
                    "cycleViolationDurationMs": 39600000,
                    "shiftDrivingViolationDurationMs": 39600000
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
                WireMock.RequestBuilders.Request.Create().WithPath("/fleet/hos/clocks").UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.HoursOfService.GetHosClocksAsync(new GetHosClocksRequest());
        JsonAssert.AreEqual(response, mockResponse);
    }
}
