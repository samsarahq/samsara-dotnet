using NUnit.Framework;
using Samsara.Net.Industrial;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.Industrial;

[TestFixture]
public class GetDataInputDataSnapshotTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "fftSpectraPoint": {
                    "time": "2020-01-27T07:06:25Z"
                  },
                  "j1939D1StatusPoint": {
                    "time": "2020-01-27T07:06:25Z"
                  },
                  "locationPoint": {
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
                  },
                  "numberPoint": {
                    "time": "2020-01-27T07:06:25Z",
                    "value": 1992.0506
                  },
                  "stringPoint": {
                    "time": "2020-01-27T07:06:25Z",
                    "value": "On"
                  },
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
                    .WithPath("/industrial/data-inputs/data-points")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Industrial.GetDataInputDataSnapshotAsync(
            new GetDataInputDataSnapshotRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
