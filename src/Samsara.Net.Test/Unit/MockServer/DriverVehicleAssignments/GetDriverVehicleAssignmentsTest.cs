using NUnit.Framework;
using Samsara.Net.DriverVehicleAssignments;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.DriverVehicleAssignments;

[TestFixture]
public class GetDriverVehicleAssignmentsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "assignedAtTime": "2019-06-13T19:08:25Z",
                  "assignmentType": "invalid",
                  "driver": {
                    "id": "45646",
                    "name": "Driver Bob"
                  },
                  "endTime": "2019-06-13T19:08:25Z",
                  "isPassenger": true,
                  "metadata": {
                    "sourceName": "ExternalSourceName"
                  },
                  "startTime": "2019-06-13T19:08:25Z",
                  "vehicle": {
                    "id": "494123",
                    "name": "Fleet Truck #1"
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
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/fleet/driver-vehicle-assignments")
                    .WithParam("filterBy", "drivers")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.DriverVehicleAssignments.GetDriverVehicleAssignmentsAsync(
            new GetDriverVehicleAssignmentsRequest
            {
                FilterBy = GetDriverVehicleAssignmentsRequestFilterBy.Drivers,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
