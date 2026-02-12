using NUnit.Framework;
using Samsara.Net.Sensors;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.Sensors;

[TestFixture]
public class V1GetSensorsDoorTest : BaseMockServerTest
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
                  "doorClosed": true,
                  "doorStatusTime": "2019-04-17T16:42:55Z",
                  "id": 122,
                  "name": "Trailer Door V1Sensor",
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
                    .WithPath("/v1/sensors/door")
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

        var response = await Client.Sensors.V1GetSensorsDoorAsync(
            new InlineObject5 { Sensors = new List<long>() { 122 } }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
