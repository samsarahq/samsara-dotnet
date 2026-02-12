using NUnit.Framework;
using Samsara.Net.CarrierProposedAssignments;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.CarrierProposedAssignments;

[TestFixture]
public class CreateCarrierProposedAssignmentTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "driverId": "42",
              "vehicleId": "123"
            }
            """;

        const string mockResponse = """
            {
              "data": {
                "acceptedTime": "2020-01-27T07:06:25Z",
                "activeTime": "2020-01-27T07:06:25Z",
                "driver": {
                  "externalIds": {
                    "maintenanceId": "250020",
                    "payrollId": "ABFS18600"
                  },
                  "id": "88668",
                  "name": "Susan Bob"
                },
                "firstSeenTime": "2020-01-27T07:06:25Z",
                "id": "08b3aeada5f4ab3010c0b4efa28d2d1890dbf8d48d2d",
                "rejectedTime": "2020-01-27T07:06:25Z",
                "shippingDocs": "Delivery 123, chips and soda",
                "trailers": [
                  {
                    "externalIds": {
                      "maintenanceId": "250020",
                      "payrollId": "ABFS18600"
                    },
                    "id": "123456789",
                    "name": "Midwest Trailer #5"
                  }
                ],
                "vehicle": {
                  "ExternalIds": {
                    "maintenanceId": "250020",
                    "payrollId": "ABFS18600"
                  },
                  "id": "123456789",
                  "name": "Midwest Truck #4"
                }
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/fleet/carrier-proposed-assignments")
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

        var response = await Client.CarrierProposedAssignments.CreateCarrierProposedAssignmentAsync(
            new CreateCarrierProposedAssignmentRequest { DriverId = "42", VehicleId = "123" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
