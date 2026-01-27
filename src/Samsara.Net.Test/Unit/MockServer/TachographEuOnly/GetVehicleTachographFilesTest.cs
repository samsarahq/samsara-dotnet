using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.Core;
using Samsara.Net.TachographEuOnly;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.TachographEuOnly;

[TestFixture]
public class GetVehicleTachographFilesTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "files": [
                    {
                      "createdAtTime": "2020-01-02T15:04:05Z07:00",
                      "id": "4aff772c-a7bb-45e6-8e41-6a53e34feb83",
                      "url": "https://samsara-tachograph-files.s3.us-west-2.amazonaws.com/123/456/789/4aff772c-a7bb-45e6-8e41-6a53e34feb83.ddd",
                      "vehicleIdentificationNumber": "1000000492436002"
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
                    .WithPath("/fleet/vehicles/tachograph-files/history")
                    .WithParam("startTime", "startTime")
                    .WithParam("endTime", "endTime")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.TachographEuOnly.GetVehicleTachographFilesAsync(
            new GetVehicleTachographFilesRequest { StartTime = "startTime", EndTime = "endTime" }
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<TachographVehicleFilesResponse>(mockResponse))
                .UsingDefaults()
        );
    }
}
