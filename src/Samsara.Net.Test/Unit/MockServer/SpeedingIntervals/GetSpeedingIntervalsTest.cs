using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.Core;
using Samsara.Net.SpeedingIntervals;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.SpeedingIntervals;

[TestFixture]
public class GetSpeedingIntervalsTest : BaseMockServerTest
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
                  "createdAtTime": "createdAtTime",
                  "driverId": "driverId",
                  "intervals": [
                    {
                      "endTime": "endTime",
                      "isDismissed": true,
                      "location": {
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
                        "headingDegrees": 1000000,
                        "latitude": 1.1,
                        "longitude": 1.1
                      },
                      "maxSpeedKilometersPerHour": 1.1,
                      "postedSpeedLimitKilometersPerHour": 1.1,
                      "severityLevel": "light",
                      "startTime": "startTime"
                    },
                    {
                      "endTime": "endTime",
                      "isDismissed": true,
                      "location": {
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
                        "headingDegrees": 1000000,
                        "latitude": 1.1,
                        "longitude": 1.1
                      },
                      "maxSpeedKilometersPerHour": 1.1,
                      "postedSpeedLimitKilometersPerHour": 1.1,
                      "severityLevel": "light",
                      "startTime": "startTime"
                    }
                  ],
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
                  "createdAtTime": "createdAtTime",
                  "driverId": "driverId",
                  "intervals": [
                    {
                      "endTime": "endTime",
                      "isDismissed": true,
                      "location": {
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
                        "headingDegrees": 1000000,
                        "latitude": 1.1,
                        "longitude": 1.1
                      },
                      "maxSpeedKilometersPerHour": 1.1,
                      "postedSpeedLimitKilometersPerHour": 1.1,
                      "severityLevel": "light",
                      "startTime": "startTime"
                    },
                    {
                      "endTime": "endTime",
                      "isDismissed": true,
                      "location": {
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
                        "headingDegrees": 1000000,
                        "latitude": 1.1,
                        "longitude": 1.1
                      },
                      "maxSpeedKilometersPerHour": 1.1,
                      "postedSpeedLimitKilometersPerHour": 1.1,
                      "severityLevel": "light",
                      "startTime": "startTime"
                    }
                  ],
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
                    .WithPath("/speeding-intervals/stream")
                    .WithParam("startTime", "startTime")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.SpeedingIntervals.GetSpeedingIntervalsAsync(
            new GetSpeedingIntervalsRequest { StartTime = "startTime" }
        );
        Assert.That(
            response,
            Is.EqualTo(
                    JsonUtils.Deserialize<SpeedingIntervalsGetSpeedingIntervalsResponseBody>(
                        mockResponse
                    )
                )
                .UsingDefaults()
        );
    }
}
