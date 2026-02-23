using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.BetaApIs;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class UpdateEngineImmobilizerStateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public void MockServerTest()
    {
        const string requestJson = """
            {
              "relayStates": [
                {
                  "id": "relay1",
                  "isOpen": true
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/beta/fleet/vehicles/1000000/immobilizer")
                    .WithHeader("Content-Type", "application/json")
                    .UsingPatch()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(WireMock.ResponseBuilders.Response.Create().WithStatusCode(200));

        Assert.DoesNotThrowAsync(async () =>
            await Client.BetaApIs.UpdateEngineImmobilizerStateAsync(
                new EngineImmobilizerUpdateEngineImmobilizerStateRequestBody
                {
                    Id = 1000000,
                    RelayStates =
                        new List<UpdateEngineImmobilizerRelayStateRequestBodyRequestBody>()
                        {
                            new UpdateEngineImmobilizerRelayStateRequestBodyRequestBody
                            {
                                Id =
                                    UpdateEngineImmobilizerRelayStateRequestBodyRequestBodyId.Relay1,
                                IsOpen = true,
                            },
                        },
                }
            )
        );
    }
}
