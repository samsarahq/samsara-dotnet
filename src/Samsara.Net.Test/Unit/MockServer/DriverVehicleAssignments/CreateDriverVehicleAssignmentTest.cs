using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.Core;
using Samsara.Net.DriverVehicleAssignments;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.DriverVehicleAssignments;

[TestFixture]
public class CreateDriverVehicleAssignmentTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "driverId": "494123",
              "vehicleId": "281474978683353"
            }
            """;

        const string mockResponse = """
            {
              "data": {
                "message": "Driver assignment was successfully submitted"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/fleet/driver-vehicle-assignments")
                    .WithHeader("Content-Type", "application/json")
                    .UsingPost()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.DriverVehicleAssignments.CreateDriverVehicleAssignmentAsync(
            new DriverVehicleAssignmentsV2CreateDriverVehicleAssignmentRequestBody
            {
                DriverId = "494123",
                VehicleId = "281474978683353",
            }
        );
        Assert.That(
            response,
            Is.EqualTo(
                    JsonUtils.Deserialize<DriverVehicleAssignmentsV2CreateDriverVehicleAssignmentResponseBody>(
                        mockResponse
                    )
                )
                .UsingDefaults()
        );
    }
}
