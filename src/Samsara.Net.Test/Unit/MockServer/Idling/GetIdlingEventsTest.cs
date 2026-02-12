using NUnit.Framework;
using Samsara.Net.Idling;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.Idling;

[TestFixture]
public class GetIdlingEventsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "address": {
                    "addressTypes": [
                      "yard",
                      "industrialSite"
                    ],
                    "id": "1234567890"
                  },
                  "airTemperatureMillicelsius": 25000,
                  "asset": {
                    "id": 1234567890
                  },
                  "durationMilliseconds": 860000,
                  "eventUuid": "1234567890",
                  "fuelConsumedMilliliters": 2500,
                  "fuelCost": {
                    "amount": "640.2",
                    "currency": "usd"
                  },
                  "gaseousFuelConsumedGrams": 2500,
                  "gaseousFuelCost": {
                    "amount": "640.2",
                    "currency": "usd"
                  },
                  "latitude": 37.7749,
                  "longitude": -122.4194,
                  "operator": {
                    "id": 1234567890
                  },
                  "ptoState": "active, inactive",
                  "startTime": "2019-06-13T17:08:25Z"
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
                    .WithPath("/idling/events")
                    .WithParam("startTime", "startTime")
                    .WithParam("endTime", "endTime")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Idling.GetIdlingEventsAsync(
            new GetIdlingEventsRequest { StartTime = "startTime", EndTime = "endTime" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
