using NUnit.Framework;
using Samsara.Net.Industrial;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.Industrial;

[TestFixture]
public class GetDataInputDataHistoryTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "fftSpectraPoints": [
                    {
                      "time": "2020-01-27T07:06:25Z"
                    }
                  ],
                  "j1939D1StatusPoints": [
                    {
                      "time": "2020-01-27T07:06:25Z"
                    }
                  ],
                  "locationPoints": [
                    {
                      "gpsLocation": {
                        "formattedAddress": "350 Rhode Island St, San Francisco CA, 94103",
                        "gpsMetersPerSecond": 35.5,
                        "headingDegrees": 91.2,
                        "latitude": 42.44817,
                        "longitude": -71.224716,
                        "place": {
                          "city": "San Francisco",
                          "houseNumber": "350",
                          "neighborhood": "Castro",
                          "poi": "400",
                          "postcode": "94103",
                          "state": "CA",
                          "street": "Rhode Island"
                        }
                      },
                      "time": "2020-01-27T07:06:25Z"
                    }
                  ],
                  "numberPoints": [
                    {
                      "time": "2020-01-27T07:06:25Z",
                      "value": 1992.0506
                    }
                  ],
                  "stringPoints": [
                    {
                      "time": "2020-01-27T07:06:25Z",
                      "value": "On"
                    }
                  ],
                  "assetId": "74771078-5edb-4733-88f2-7242f520d1f1",
                  "dataGroup": "Flow",
                  "id": "id",
                  "name": "Pump Flow",
                  "units": "Gallons Per Minute"
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
                    .WithPath("/industrial/data-inputs/data-points/history")
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

        var response = await Client.Industrial.GetDataInputDataHistoryAsync(
            new GetDataInputDataHistoryRequest { StartTime = "startTime", EndTime = "endTime" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
