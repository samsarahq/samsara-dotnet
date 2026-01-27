using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.Core;
using Samsara.Net.DriverVehicleAssignments;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.DriverVehicleAssignments;

[TestFixture]
public class UpdateDriverVehicleAssignmentTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "driverId": "494123",
              "startTime": "2019-06-13T19:08:25.000Z",
              "vehicleId": "281474978683353"
            }
            """;

        const string mockResponse = """
            {
              "data": {
                "message": "Driver assignment was successfully updated"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/fleet/driver-vehicle-assignments")
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

        var response = await Client.DriverVehicleAssignments.UpdateDriverVehicleAssignmentAsync(
            new DriverVehicleAssignmentsV2UpdateDriverVehicleAssignmentRequestBody
            {
                DriverId = "494123",
                StartTime = "2019-06-13T19:08:25Z",
                VehicleId = "281474978683353",
            }
        );
        Assert.That(
            response,
            Is.EqualTo(
                    JsonUtils.Deserialize<DriverVehicleAssignmentsV2UpdateDriverVehicleAssignmentResponseBody>(
                        mockResponse
                    )
                )
                .UsingDefaults()
        );
    }
}
