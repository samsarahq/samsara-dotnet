using NUnit.Framework;
using Samsara.Net.Sensors;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.Sensors;

[TestFixture]
public class V1GetSensorsCargoTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "sensors": [
                122
              ]
            }
            """;

        const string mockResponse = """
            {
              "groupId": 101,
              "sensors": [
                {
                  "cargoEmpty": true,
                  "cargoStatusTime": "2019-04-17T16:42:55Z",
                  "id": 122,
                  "name": "Trailer Cargo V1Sensor",
                  "redEyeDistance": 175,
                  "trailerId": 123,
                  "vehicleId": 124
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/sensors/cargo")
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

        var response = await Client.Sensors.V1GetSensorsCargoAsync(
            new InlineObject4 { Sensors = new List<long>() { 122 } }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
