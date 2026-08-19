using NUnit.Framework;
using Samsara.Net.BetaApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class ListWarrantiesTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "baseCoverage": {
                    "description": "12345",
                    "durationDays": 12345,
                    "durationMonths": 12345,
                    "engineDurationHours": 12345,
                    "isOdometerDistanceUnlimited": true,
                    "name": "12345",
                    "notes": "12345",
                    "odometerDistanceMeters": 12345,
                    "startEngineHours": 12345,
                    "startOdometerMeters": 12345,
                    "startTime": "2019-06-13T19:08:25Z"
                  },
                  "coverages": [
                    {
                      "description": "12345",
                      "durationDays": 12345,
                      "durationMonths": 12345,
                      "engineDurationHours": 12345,
                      "isOdometerDistanceUnlimited": true,
                      "name": "12345",
                      "notes": "12345",
                      "odometerDistanceMeters": 12345,
                      "startEngineHours": 12345,
                      "startOdometerMeters": 12345,
                      "startTime": "2019-06-13T19:08:25Z"
                    }
                  ],
                  "createdAtTime": "2019-06-13T19:08:25Z",
                  "description": "12345",
                  "durationDays": 12345,
                  "durationMonths": 12345,
                  "engineDurationHours": 12345,
                  "externalIds": [
                    {
                      "key": "12345",
                      "value": "12345"
                    }
                  ],
                  "id": "12345",
                  "name": "12345",
                  "odometerDistanceMeters": 12345,
                  "updatedAtTime": "2019-06-13T19:08:25Z",
                  "vendor": {
                    "id": "281474976710656"
                  },
                  "warrantyType": "12345"
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
                    .WithPath("/maintenance/warranties")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.BetaApIs.ListWarrantiesAsync(new ListWarrantiesRequest());
        JsonAssert.AreEqual(response, mockResponse);
    }
}
