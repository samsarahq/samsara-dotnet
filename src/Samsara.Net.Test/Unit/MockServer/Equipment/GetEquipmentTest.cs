using NUnit.Framework;
using Samsara.Net.Equipment;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.Equipment;

[TestFixture]
public class GetEquipmentTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": {
                "assetSerial": "1FUJA6BD31LJ09646",
                "externalIds": {
                  "maintenanceId": "250020",
                  "payrollId": "ABFS18600"
                },
                "id": "112",
                "installedGateway": {
                  "model": "Ag26",
                  "serial": "serial"
                },
                "name": "Crane A7",
                "notes": "These are notes about this given equipment.",
                "tags": [
                  {
                    "id": "3914",
                    "name": "East Coast",
                    "parentTagId": "4815"
                  }
                ]
              }
            }
            """;

        Server
            .Given(
                WireMock.RequestBuilders.Request.Create().WithPath("/fleet/equipment/id").UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Equipment.GetEquipmentAsync(
            new GetEquipmentRequest { Id = "id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
