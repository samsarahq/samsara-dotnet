using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.FuelAndEnergy;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.FuelAndEnergy;

[TestFixture]
public class PostFuelPurchaseTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "fuelQuantityLiters": "676.8",
              "transactionLocation": "350 Rhode Island St, San Francisco, CA 94103",
              "transactionPrice": {
                "amount": "640.2",
                "currency": "usd"
              },
              "transactionReference": "5454534",
              "transactionTime": "2022-07-13T14:20:50.52-07:00"
            }
            """;

        const string mockResponse = """
            {
              "data": {
                "uuid": "9814a1fa-f0c6-408b-bf85-51dc3bc71ac7"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/fuel-purchase")
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

        var response = await Client.FuelAndEnergy.PostFuelPurchaseAsync(
            new FuelPurchasePostFuelPurchaseRequestBody
            {
                FuelQuantityLiters = "676.8",
                TransactionLocation = "350 Rhode Island St, San Francisco, CA 94103",
                TransactionPrice = new PostFuelPurchaseRequestBodyPriceRequestBody
                {
                    Amount = "640.2",
                    Currency = PostFuelPurchaseRequestBodyPriceRequestBodyCurrency.Usd,
                },
                TransactionReference = "5454534",
                TransactionTime = "2022-07-13T14:20:50.52-07:00",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
