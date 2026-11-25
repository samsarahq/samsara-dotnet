using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.BetaApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class PostElectricPurchaseTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "energyKilowattHours": "42.7",
              "transactionLocation": "350 Rhode Island St, San Francisco, CA 94103",
              "transactionPrice": {
                "amount": "640.2",
                "currency": "usd"
              },
              "transactionReference": "CP-88231",
              "transactionTime": "2026-10-12T08:41:05-07:00"
            }
            """;

        const string mockResponse = """
            {
              "data": {
                "discount": {
                  "amount": "640.2",
                  "currency": "usd"
                },
                "driverId": "1234",
                "energyKilowattHours": "42.7",
                "id": "9814a1fa-f0c6-408b-bf85-51dc3bc71ac7",
                "merchantName": "ChargePoint",
                "source": "ChargePoint Integration",
                "transactionLocation": "350 Rhode Island St, San Francisco, CA 94103",
                "transactionPrice": {
                  "amount": "640.2",
                  "currency": "usd"
                },
                "transactionReference": "CP-88231",
                "transactionTime": "2026-10-12T08:41:05-07:00",
                "vehicleId": "281474900488527"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/electric-purchase")
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

        var response = await Client.BetaApIs.PostElectricPurchaseAsync(
            new FuelPurchasePostElectricPurchaseRequestBody
            {
                EnergyKilowattHours = "42.7",
                TransactionLocation = "350 Rhode Island St, San Francisco, CA 94103",
                TransactionPrice = new PostElectricPurchaseRequestBodyPriceRequestBody
                {
                    Amount = "640.2",
                    Currency = PostElectricPurchaseRequestBodyPriceRequestBodyCurrency.Usd,
                },
                TransactionReference = "CP-88231",
                TransactionTime = "2026-10-12T08:41:05-07:00",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
