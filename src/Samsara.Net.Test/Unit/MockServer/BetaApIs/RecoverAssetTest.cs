using NUnit.Framework;
using Samsara.Net.BetaApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class RecoverAssetTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "missing_reason": "MISPLACED",
              "recovery_status": "YES",
              "status": "RECOVERED"
            }
            """;

        const string mockResponse = """
            {
              "data": {
                "id": "12345",
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
                "recovery_photos": [
                  {
                    "start_ms": 1609459200000,
                    "status": "EXISTS",
                    "url": "https://s3.amazonaws.com/samsara-recovery-photos/example.jpg",
                    "url_expires_at_ms": 1609462800000
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
                    .WithPath("/fleet/assets/device-recovery/id/recovered")
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

        var response = await Client.BetaApIs.RecoverAssetAsync(
            new DeviceRecoveryRecoverAssetRequestBody
            {
                Id = "id",
                MissingReason = DeviceRecoveryRecoverAssetRequestBodyMissingReason.Misplaced,
                RecoveryStatus = DeviceRecoveryRecoverAssetRequestBodyRecoveryStatus.Yes,
                Status = DeviceRecoveryRecoverAssetRequestBodyStatus.Recovered,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
