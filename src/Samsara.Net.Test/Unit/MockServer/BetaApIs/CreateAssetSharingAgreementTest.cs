using NUnit.Framework;
using Samsara.Net.BetaApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class CreateAssetSharingAgreementTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "operator": "provider",
              "providerDataPackages": [
                "all",
                "maintenance",
                "maintenance",
                "maintenance"
              ],
              "recipientDataPackages": [
                "all",
                "reefer",
                "all",
                "maintenance"
              ],
              "recipientOrganizationId": "456",
              "recipientOrganizationName": "Acme Logistics"
            }
            """;

        const string mockResponse = """
            {
              "data": {
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
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/fleet/asset-sharing/agreements")
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

        var response = await Client.BetaApIs.CreateAssetSharingAgreementAsync(
            new AssetSharingAgreementsCreateAssetSharingAgreementRequestBody
            {
                Operator =
                    AssetSharingAgreementsCreateAssetSharingAgreementRequestBodyOperator.Provider,
                ProviderDataPackages =
                    new List<AssetSharingAgreementsCreateAssetSharingAgreementRequestBodyProviderDataPackagesItem>()
                    {
                        AssetSharingAgreementsCreateAssetSharingAgreementRequestBodyProviderDataPackagesItem.All,
                        AssetSharingAgreementsCreateAssetSharingAgreementRequestBodyProviderDataPackagesItem.Maintenance,
                        AssetSharingAgreementsCreateAssetSharingAgreementRequestBodyProviderDataPackagesItem.Maintenance,
                        AssetSharingAgreementsCreateAssetSharingAgreementRequestBodyProviderDataPackagesItem.Maintenance,
                    },
                RecipientDataPackages =
                    new List<AssetSharingAgreementsCreateAssetSharingAgreementRequestBodyRecipientDataPackagesItem>()
                    {
                        AssetSharingAgreementsCreateAssetSharingAgreementRequestBodyRecipientDataPackagesItem.All,
                        AssetSharingAgreementsCreateAssetSharingAgreementRequestBodyRecipientDataPackagesItem.Reefer,
                        AssetSharingAgreementsCreateAssetSharingAgreementRequestBodyRecipientDataPackagesItem.All,
                        AssetSharingAgreementsCreateAssetSharingAgreementRequestBodyRecipientDataPackagesItem.Maintenance,
                    },
                RecipientOrganizationId = "456",
                RecipientOrganizationName = "Acme Logistics",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
