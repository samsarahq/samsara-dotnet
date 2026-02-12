using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.Sensors;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.Sensors;

[TestFixture]
public class V1GetSensorsHistoryTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "endMs": 1462881998034,
              "series": [
                {
                  "field": "ambientTemperature",
                  "widgetId": 1
                }
              ],
              "startMs": 1462878398034,
              "stepMs": 3600000
            }
            """;

        const string mockResponse = """
            {
              "results": [
                {
                  "series": [
                    1
                  ],
                  "timeMs": 1453449599999
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/sensors/history")
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

        var response = await Client.Sensors.V1GetSensorsHistoryAsync(
            new InlineObject6
            {
                EndMs = 1462881998034,
                Series = new List<V1SensorsHistorySeries>()
                {
                    new V1SensorsHistorySeries
                    {
                        Field = V1SensorsHistorySeriesField.AmbientTemperature,
                        WidgetId = 1,
                    },
                },
                StartMs = 1462878398034,
                StepMs = 3600000,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
