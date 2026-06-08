using NUnit.Framework;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.Sensors;

[TestFixture]
public class V1GetSensorsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "sensors": [
                {
                  "activatedAtMs": 1635881752799,
                  "healthStatus": "RequiresInvestigation",
                  "id": 123,
                  "lastTransmissionAtMs": 1613440186723,
                  "macAddress": "11:11:11:11:11:11",
                  "name": "Freezer ABC",
                  "sensorType": "EM21"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock.RequestBuilders.Request.Create().WithPath("/v1/sensors/list").UsingPost()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Sensors.V1GetSensorsAsync();
        JsonAssert.AreEqual(response, mockResponse);
    }
}
