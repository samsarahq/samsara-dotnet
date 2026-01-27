using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.Core;
using Samsara.Net.Equipment;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.Equipment;

[TestFixture]
public class GetEquipmentLocationsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "id": "112",
                  "location": {
                    "heading": 120,
                    "latitude": 122.142,
                    "longitude": -93.343,
                    "speed": 48.3,
                    "time": "2020-01-27T07:06:25.000Z"
                  },
                  "name": "Crane A7"
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
                    .WithPath("/fleet/equipment/locations")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Equipment.GetEquipmentLocationsAsync(
            new GetEquipmentLocationsRequest()
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<EquipmentLocationsResponse>(mockResponse))
                .UsingDefaults()
        );
    }
}
