using NUnit.Framework;
using Samsara.Net.LegacyApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.LegacyApIs;

[TestFixture]
public class GetDriversVehicleAssignmentsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "driverActivationStatus": "active",
                  "externalIds": {
                    "key": "value"
                  },
                  "id": "494123",
                  "name": "Joe Driver",
                  "vehicleAssignments": [
                    {
                      "assignmentType": "driverApp",
                      "endTime": "2019-06-13T19:08:25Z",
                      "isPassenger": false,
                      "startTime": "2019-06-13T19:08:25Z",
                      "vehicle": {
                        "id": "494123",
                        "name": "Fleet Truck #1"
                      }
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
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/fleet/drivers/vehicle-assignments")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.LegacyApIs.GetDriversVehicleAssignmentsAsync(
            new GetDriversVehicleAssignmentsRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
