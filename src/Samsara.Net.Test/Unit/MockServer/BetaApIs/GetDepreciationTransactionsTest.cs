using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.BetaApIs;
using Samsara.Net.Core;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class GetDepreciationTransactionsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "amount": {
                    "amount": "640.2",
                    "currency": "usd"
                  },
                  "assetId": "281474993384538",
                  "costCenterId": "5523a39f-42ef-4820-83d0-dfe73dbe7853",
                  "createdAt": "2024-12-05T10:30:00.000Z",
                  "eventTime": "2024-11-30T23:59:59.000Z",
                  "id": "9814a1fa-f0c6-408b-bf85-51dc3bc71ac7",
                  "note": "November 2024 monthly depreciation",
                  "transactionType": "depreciation",
                  "updatedAt": "2024-12-05T10:30:00.000Z"
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
                    .WithPath("/assets/depreciation")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.BetaApIs.GetDepreciationTransactionsAsync(
            new GetDepreciationTransactionsRequest()
        );
        Assert.That(
            response,
            Is.EqualTo(
                    JsonUtils.Deserialize<DepreciationGetDepreciationTransactionsResponseBody>(
                        mockResponse
                    )
                )
                .UsingDefaults()
        );
    }
}
