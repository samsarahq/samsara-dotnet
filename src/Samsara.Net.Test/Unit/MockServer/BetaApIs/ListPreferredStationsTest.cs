using NUnit.Framework;
using Samsara.Net.BetaApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class ListPreferredStationsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "address": {
                    "city": "Green River",
                    "country": "US",
                    "line1": "8901 US Hwy 374",
                    "postalCode": "82935",
                    "state": "WY"
                  },
                  "discounts": [
                    {
                      "discount": {
                        "amount": "640.2",
                        "currency": "usd"
                      },
                      "discountPercent": "3.5",
                      "discountType": "centsPerUnit",
                      "fuelType": "gasoline"
                    }
                  ],
                  "externalIds": {
                    "key": "value"
                  },
                  "id": "sta_abc123",
                  "latitude": 41.5168,
                  "longitude": -109.471,
                  "name": "Pilot Travel Center #432",
                  "prices": [
                    {
                      "fuelType": "gasoline",
                      "grossPrice": {
                        "amount": "640.2",
                        "currency": "usd"
                      },
                      "netPrice": {
                        "amount": "640.2",
                        "currency": "usd"
                      },
                      "volumeUnit": "liter"
                    }
                  ]
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
                WireMock.RequestBuilders.Request.Create().WithPath("/preferred-stations").UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.BetaApIs.ListPreferredStationsAsync(
            new ListPreferredStationsRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
