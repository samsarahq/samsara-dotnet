using NUnit.Framework;
using Samsara.Net.BetaApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class ListDeviceRecoveryMissingAssetsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
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
                    .WithPath("/fleet/assets/device-recovery-missing")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.BetaApIs.ListDeviceRecoveryMissingAssetsAsync(
            new ListDeviceRecoveryMissingAssetsRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
