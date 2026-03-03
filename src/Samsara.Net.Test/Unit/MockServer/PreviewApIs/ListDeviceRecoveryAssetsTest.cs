using NUnit.Framework;
using Samsara.Net.PreviewApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.PreviewApIs;

[TestFixture]
public class ListDeviceRecoveryAssetsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "additional_details": "Found in warehouse B",
                  "id": "12345",
                  "missing_reason": "MISPLACED",
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
                  "recovery_photos": [
                    {
                      "start_ms": 1609459200000,
                      "status": "EXISTS",
                      "url": "https://s3.amazonaws.com/samsara-recovery-photos/example.jpg",
                      "url_expires_at_ms": 1609462800000
                    }
                  ],
                  "recovery_status": "YES",
                  "status": "UNKNOWN",
                  "updated_at_ms": 1609459200000,
                  "updated_by_user_id": 1234,
                  "uuid": "550e8400-e29b-41d4-a716-446655440000"
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
                    .WithPath("/preview/fleet/assets/device-recovery")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.PreviewApIs.ListDeviceRecoveryAssetsAsync(
            new ListDeviceRecoveryAssetsRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
