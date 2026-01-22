using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.Core;
using Samsara.Net.DriverVehicleAssignments;
using Samsara.Net.Test.Unit.MockServer;

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
                  "assignedAtTime": "2019-06-13T19:08:25.000Z",
                  "assignmentType": "invalid",
                  "driver": {
                    "id": "45646",
                    "name": "Driver Bob"
                  },
                  "endTime": "2019-06-13T19:08:25.000Z",
                  "isPassenger": true,
                  "metadata": {
                    "sourceName": "ExternalSourceName"
                  },
                  "startTime": "2019-06-13T19:08:25.000Z",
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
        Assert.That(
            response,
            Is.EqualTo(
                    JsonUtils.Deserialize<DriverVehicleAssignmentsV2GetDriverVehicleAssignmentsResponseBody>(
                        mockResponse
                    )
                )
                .UsingDefaults()
        );
    }
}
