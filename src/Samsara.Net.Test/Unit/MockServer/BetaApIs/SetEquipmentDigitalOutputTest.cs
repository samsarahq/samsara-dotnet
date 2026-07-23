using NUnit.Framework;
using Samsara.Net.BetaApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class SetEquipmentDigitalOutputTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "pinId": 1,
              "state": true
            }
            """;

        const string mockResponse = """
            {
              "data": {
                "durationSeconds": 60,
                "id": 1234,
                "pinId": 1,
                "state": true
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/fleet/equipment/1000000/digital-output")
                    .WithHeader("Content-Type", "application/json")
                    .UsingPatch()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.BetaApIs.SetEquipmentDigitalOutputAsync(
            new EquipmentOutputControlSetEquipmentDigitalOutputRequestBody
            {
                Id = 1000000,
                PinId = 1,
                State = true,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
