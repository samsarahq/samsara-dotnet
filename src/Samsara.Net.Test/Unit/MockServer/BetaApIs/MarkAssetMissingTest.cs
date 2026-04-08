using NUnit.Framework;
using Samsara.Net.BetaApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class MarkAssetMissingTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {}
            """;

        const string mockResponse = """
            {
              "data": {
                "id": "12345",
                "initiated_at_ms": 1609459200000,
                "initiated_by_user_id": 1234,
                "name": "Trailer-A1234",
                "note": "Asset was last seen at warehouse A",
                "notification_recipients": [
                  {
                    "email": "jane.doe@example.com",
                    "name": "Jane Doe",
                    "notification_types": [
                      "email"
                    ],
                    "user_id": 1234
                  }
                ],
                "update_source": "dashboard",
                "updated_at_ms": 1609459200000,
                "updated_by_user_id": 1234
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/fleet/assets/device-recovery/id/missing")
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

        var response = await Client.BetaApIs.MarkAssetMissingAsync(
            new DeviceRecoveryMarkAssetMissingRequestBody { Id = "id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
