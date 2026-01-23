using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.BetaApIs;
using Samsara.Net.Core;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class GetAempEquipmentListTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "Fleet": {
                "Equipment": [
                  {
                    "EquipmentHeader": {
                      "EquipmentID": "494123",
                      "Model": "S630 T4",
                      "OEMName": "Bobcat",
                      "PIN": "8V8WD530FLN016251",
                      "SerialNumber": "8V8WD530FLN016251",
                      "UnitInstallDateTime": "2019-06-13T19:08:25.000Z"
                    },
                    "Location": {
                      "Latitude": 12.34,
                      "Longitude": 12.34,
                      "datetime": "2019-06-13T19:08:25.000Z"
                    }
                  }
                ],
                "Links": [
                  {
                    "href": "https://api.samsara.com/aemp/Fleet/1",
                    "rel": "self"
                  }
                ],
                "snapshotTime": "2019-06-13T19:08:25.000Z",
                "version": "1"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/beta/aemp/Fleet/pageNumber")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.BetaApIs.GetAempEquipmentListAsync(
            new GetAempEquipmentListRequest { PageNumber = "pageNumber" }
        );
        Assert.That(
            response,
            Is.EqualTo(
                    JsonUtils.Deserialize<AempEquipmentGetAempEquipmentListResponseBody>(
                        mockResponse
                    )
                )
                .UsingDefaults()
        );
    }
}
