using NUnit.Framework;
using Samsara.Net.Routes;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.Routes;

[TestFixture]
public class FetchRouteTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": {
                "actualRouteEndTime": "2019-06-13T19:08:25.000Z",
                "actualRouteStartTime": "2019-06-13T19:08:25.000Z",
                "driver": {
                  "externalIds": {
                    "key": "value"
                  },
                  "id": "45646",
                  "name": "Driver Bob"
                },
                "externalIds": {
                  "key": "value"
                },
                "id": "342341",
                "name": "Bid 123",
                "notes": "These are my notes",
                "orgLocalTimezone": "America/Los_Angeles",
                "recurringRouteLiveSharingLinks": [
                  {
                    "expiresAtTime": "2020-01-27T07:06:25Z",
                    "liveSharingUrl": "https://cloud.samsara.com/o/123456/fleet/viewer/address/gEAitEnnOwcv92cuPzcU",
                    "name": "Name"
                  }
                ],
                "scheduledRouteEndTime": "2019-06-13T19:08:25.000Z",
                "scheduledRouteStartTime": "2019-06-13T19:08:25.000Z",
                "settings": {
                  "routeCompletionCondition": "arriveLastStop",
                  "routeStartingCondition": "departFirstStop",
                  "sequencingMethod": "unknown"
                },
                "stops": [
                  {
                    "actualArrivalTime": "2006-01-02T08:04:05.000Z",
                    "actualDepartureTime": "2006-01-02T08:04:05.000Z",
                    "actualDistanceMeters": 5450,
                    "address": {
                      "id": "494123",
                      "name": "Company Office #1"
                    },
                    "documents": [
                      {
                        "id": "494123",
                        "name": "Fuel Receipt Wichita"
                      }
                    ],
                    "enRouteTime": "2006-01-02T08:04:05.000Z",
                    "eta": "2006-01-02T08:04:05.000Z",
                    "forms": [
                      {
                        "id": "41234"
                      }
                    ],
                    "id": "324231",
                    "issues": [
                      {
                        "id": "32812"
                      }
                    ],
                    "liveSharingUrl": "https://cloud.samsara.com/fleet/viewer/job/fleet_viewer_token",
                    "locationLiveSharingLinks": [
                      {
                        "expiresAtTime": "2020-01-27T07:06:25Z",
                        "liveSharingUrl": "https://cloud.samsara.com/o/123456/fleet/viewer/address/gEAitEnnOwcv92cuPzcU",
                        "name": "Name"
                      }
                    ],
                    "name": "Stop #1",
                    "notes": "These are my notes",
                    "ontimeWindowAfterArrivalMs": 300000,
                    "ontimeWindowBeforeArrivalMs": 300000,
                    "plannedDistanceMeters": 5200,
                    "scheduledArrivalTime": "2019-06-13T19:08:25.000Z",
                    "scheduledDepartureTime": "2019-06-13T19:08:25.000Z",
                    "sequenceNumber": 10,
                    "singleUseLocation": {
                      "address": "1234 Main St, San Jose, CA",
                      "latitude": 123.456,
                      "longitude": 37.459,
                      "radiusMeters": 100
                    },
                    "skippedTime": "2006-01-02T08:04:05.000Z",
                    "state": "unassigned"
                  }
                ],
                "tagIds": [
                  "123",
                  "321"
                ],
                "vehicle": {
                  "externalIds": {
                    "key": "value"
                  },
                  "id": "494123",
                  "name": "Fleet Truck #1"
                }
              }
            }
            """;

        Server
            .Given(
                WireMock.RequestBuilders.Request.Create().WithPath("/fleet/routes/id").UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Routes.FetchRouteAsync("id", new FetchRouteRequest());
        JsonAssert.AreEqual(response, mockResponse);
    }
}
