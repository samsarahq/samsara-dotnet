using NUnit.Framework;
using Samsara.Net.BetaApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class ListAssetSharingAgreementsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "acceptedAtTime": "2024-01-15T11:00:00Z",
                  "acceptedByUserId": "678",
                  "canceledAtTime": "2024-01-15T11:00:00Z",
                  "canceledByParty": "provider",
                  "canceledByUserId": "678",
                  "createdAtTime": "2024-01-13T10:00:00Z",
                  "createdByUserId": "111",
                  "deletedByUserId": "111",
                  "id": "33333333-3333-3333-3333-333333333333",
                  "operator": "provider",
                  "providerDataPackages": [
                    "safety",
                    "maintenance"
                  ],
                  "providerOrganizationId": "123",
                  "recipientDataPackages": [
                    "telematics",
                    "location",
                    "telematics",
                    "all"
                  ],
                  "recipientOrganizationId": "456",
                  "rejectedAtTime": "2024-01-15T11:00:00Z",
                  "rejectedByUserId": "678",
                  "status": "pending",
                  "updatedAtTime": "2024-01-13T10:00:00Z"
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
                    .WithPath("/fleet/asset-sharing/agreements")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.BetaApIs.ListAssetSharingAgreementsAsync(
            new ListAssetSharingAgreementsRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
