using NUnit.Framework;
using Samsara.Net.PreviewApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.PreviewApIs;

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
                "name": "Trailer-A1234",
                "note": "Asset was last seen at warehouse A",
                "notification_recipients": [
                  {
                    "notification_types": [
                      "email"
                    ],
                    "user_id": 1234
                  }
                ],
                "updated_at_ms": 1609459200000,
                "updated_by_user_id": 1234,
                "uuid": "550e8400-e29b-41d4-a716-446655440000"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/preview/fleet/assets/device-recovery/id/missing")
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

        var response = await Client.PreviewApIs.MarkAssetMissingAsync(
            new DeviceRecoveryMarkAssetMissingRequestBody { Id = "id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
