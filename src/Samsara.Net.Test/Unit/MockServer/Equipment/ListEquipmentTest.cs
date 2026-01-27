using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.Core;
using Samsara.Net.Equipment;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.Equipment;

[TestFixture]
public class ListEquipmentTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "assetSerial": "1FUJA6BD31LJ09646",
                  "externalIds": {
                    "maintenanceId": "250020",
                    "payrollId": "ABFS18600"
                  },
                  "id": "112",
                  "installedGateway": {
                    "model": "Ag26"
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
              ],
              "pagination": {
                "endCursor": "MjkY",
                "hasNextPage": true
              }
            }
            """;

        Server
            .Given(
                WireMock.RequestBuilders.Request.Create().WithPath("/fleet/equipment").UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Equipment.ListEquipmentAsync(new ListEquipmentRequest());
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<EquipmentListResponse>(mockResponse)).UsingDefaults()
        );
    }
}
