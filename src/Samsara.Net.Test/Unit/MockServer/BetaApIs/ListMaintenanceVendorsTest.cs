using NUnit.Framework;
using Samsara.Net.BetaApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class ListMaintenanceVendorsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "addressId": "281474993384538",
                  "categoryIds": [
                    "a1b2c3d4-e5f6-7890-abcd-ef1234567890",
                    "a1b2c3d4-e5f6-7890-abcd-ef1234567890",
                    "a1b2c3d4-e5f6-7890-abcd-ef1234567890"
                  ],
                  "externalIds": {
                    "key": "value"
                  },
                  "id": "9814a1fa-f0c6-408b-bf85-51dc3bc71ac7",
                  "servicesProvided": "Oil changes, tire rotations, brake services"
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
                    .WithPath("/fleet/maintenance/vendors")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.BetaApIs.ListMaintenanceVendorsAsync(
            new ListMaintenanceVendorsRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
