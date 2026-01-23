using NUnit.Framework;
using Samsara.Net.DriverVehicleAssignments;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.DriverVehicleAssignments;

[TestFixture]
public class DeleteDriverVehicleAssignmentsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public void MockServerTest()
    {
        const string requestJson = """
            {
              "vehicleId": "281474978683353"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/fleet/driver-vehicle-assignments")
                    .WithHeader("Content-Type", "application/json")
                    .UsingDelete()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(WireMock.ResponseBuilders.Response.Create().WithStatusCode(200));

        Assert.DoesNotThrowAsync(async () =>
            await Client.DriverVehicleAssignments.DeleteDriverVehicleAssignmentsAsync(
                new DriverVehicleAssignmentsV2DeleteDriverVehicleAssignmentsRequestBody
                {
                    VehicleId = "281474978683353",
                }
            )
        );
    }
}
