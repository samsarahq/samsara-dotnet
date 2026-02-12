using NUnit.Framework;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;
using Samsara.Net.Trips;

namespace Samsara.Net.Test.Unit.MockServer.Trips;

[TestFixture]
public class GetTripsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "asset": {
                    "id": "id",
                    "name": "name",
                    "type": "uncategorized",
                    "vin": "vin"
                  },
                  "completionStatus": "inProgress",
                  "createdAtTime": "createdAtTime",
                  "endLocation": {
                    "accuracyMeters": 1.1,
                    "address": {
                      "city": "city",
                      "country": "country",
                      "neighborhood": "neighborhood",
                      "pointOfInterest": "pointOfInterest",
                      "postalCode": "postalCode",
                      "state": "state",
                      "street": "street",
                      "streetNumber": "streetNumber"
                    },
                    "geofence": {
                      "externalIds": {
                        "externalIds": "externalIds"
                      },
                      "id": "id"
                    },
                    "headingDegrees": 1000000,
                    "latitude": 1.1,
                    "longitude": 1.1
                  },
                  "startLocation": {
                    "accuracyMeters": 1.1,
                    "address": {
                      "city": "city",
                      "country": "country",
                      "neighborhood": "neighborhood",
                      "pointOfInterest": "pointOfInterest",
                      "postalCode": "postalCode",
                      "state": "state",
                      "street": "street",
                      "streetNumber": "streetNumber"
                    },
                    "geofence": {
                      "externalIds": {
                        "externalIds": "externalIds"
                      },
                      "id": "id"
                    },
                    "headingDegrees": 1000000,
                    "latitude": 1.1,
                    "longitude": 1.1
                  },
                  "tripEndTime": "tripEndTime",
                  "tripStartTime": "tripStartTime",
                  "updatedAtTime": "updatedAtTime"
                },
                {
                  "asset": {
                    "id": "id",
                    "name": "name",
                    "type": "uncategorized",
                    "vin": "vin"
                  },
                  "completionStatus": "inProgress",
                  "createdAtTime": "createdAtTime",
                  "endLocation": {
                    "accuracyMeters": 1.1,
                    "address": {
                      "city": "city",
                      "country": "country",
                      "neighborhood": "neighborhood",
                      "pointOfInterest": "pointOfInterest",
                      "postalCode": "postalCode",
                      "state": "state",
                      "street": "street",
                      "streetNumber": "streetNumber"
                    },
                    "geofence": {
                      "externalIds": {
                        "externalIds": "externalIds"
                      },
                      "id": "id"
                    },
                    "headingDegrees": 1000000,
                    "latitude": 1.1,
                    "longitude": 1.1
                  },
                  "startLocation": {
                    "accuracyMeters": 1.1,
                    "address": {
                      "city": "city",
                      "country": "country",
                      "neighborhood": "neighborhood",
                      "pointOfInterest": "pointOfInterest",
                      "postalCode": "postalCode",
                      "state": "state",
                      "street": "street",
                      "streetNumber": "streetNumber"
                    },
                    "geofence": {
                      "externalIds": {
                        "externalIds": "externalIds"
                      },
                      "id": "id"
                    },
                    "headingDegrees": 1000000,
                    "latitude": 1.1,
                    "longitude": 1.1
                  },
                  "tripEndTime": "tripEndTime",
                  "tripStartTime": "tripStartTime",
                  "updatedAtTime": "updatedAtTime"
                }
              ],
              "pagination": {
                "endCursor": "endCursor",
                "hasNextPage": true
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/trips/stream")
                    .WithParam("startTime", "startTime")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Trips.GetTripsAsync(
            new GetTripsRequest { StartTime = "startTime" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
