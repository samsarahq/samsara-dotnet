using NUnit.Framework;
using Samsara.Net.CarrierProposedAssignments;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.CarrierProposedAssignments;

[TestFixture]
public class ListCarrierProposedAssignmentsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
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
                    .WithPath("/fleet/carrier-proposed-assignments")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.CarrierProposedAssignments.ListCarrierProposedAssignmentsAsync(
            new ListCarrierProposedAssignmentsRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
