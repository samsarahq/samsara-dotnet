using NUnit.Framework;
using Samsara.Net.BetaApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class GetDriverEfficiencyTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": {
                "driverSummaries": [
                  {
                    "driver": {
                      "id": "88668",
                      "name": "Susan Bob",
                      "username": "susanbob"
                    },
                    "vehicleSummaries": [
                      {
                        "vehicle": {
                          "ExternalIds": {
                            "maintenanceId": "250020",
                            "payrollId": "ABFS18600"
                          },
                          "id": "123456789",
                          "name": "Midwest Truck #4"
                        }
                      }
                    ]
                  }
                ],
                "summaryEndTime": "2020-03-16T16:00:00.000Z",
                "summaryStartTime": "2020-03-15T16:00:00.000Z"
              },
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
                    .WithPath("/beta/fleet/drivers/efficiency")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.BetaApIs.GetDriverEfficiencyAsync(
            new GetDriverEfficiencyRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
