using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.Core;
using Samsara.Net.LegacyApIs;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.LegacyApIs;

[TestFixture]
public class GetVehiclesDriverAssignmentsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "driverAssignments": [
                    {
                      "driver": {
                        "id": "45646",
                        "name": "Driver Bob"
                      },
                      "endTime": "2019-06-13T19:08:25.000Z",
                      "isPassenger": false,
                      "startTime": "2019-06-13T19:08:25.000Z"
                    }
                  ],
                  "externalIds": {
                    "key": "value"
                  },
                  "id": "494123",
                  "name": "Bus-123"
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
                    .WithPath("/fleet/vehicles/driver-assignments")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.LegacyApIs.GetVehiclesDriverAssignmentsAsync(
            new GetVehiclesDriverAssignmentsRequest()
        );
        Assert.That(
            response,
            Is.EqualTo(
                    JsonUtils.Deserialize<VehiclesDriverAssignmentsGetVehiclesDriverAssignmentsResponseBody>(
                        mockResponse
                    )
                )
                .UsingDefaults()
        );
    }
}
