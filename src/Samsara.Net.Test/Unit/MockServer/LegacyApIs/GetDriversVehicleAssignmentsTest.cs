using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.Core;
using Samsara.Net.LegacyApIs;
using Samsara.Net.Test.Unit.MockServer;

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
                      "endTime": "2019-06-13T19:08:25.000Z",
                      "isPassenger": false,
                      "startTime": "2019-06-13T19:08:25.000Z",
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
        Assert.That(
            response,
            Is.EqualTo(
                    JsonUtils.Deserialize<DriversVehicleAssignmentsGetDriversVehicleAssignmentsResponseBody>(
                        mockResponse
                    )
                )
                .UsingDefaults()
        );
    }
}
