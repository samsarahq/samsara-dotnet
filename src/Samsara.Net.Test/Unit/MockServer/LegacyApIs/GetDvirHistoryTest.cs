using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.Core;
using Samsara.Net.LegacyApIs;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.LegacyApIs;

[TestFixture]
public class GetDvirHistoryTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "authorSignature": {
                    "signedAtTime": "2020-01-27T07:06:25.000Z"
                  },
                  "endTime": "2020-01-27T07:06:25.000Z",
                  "id": "7107471",
                  "licensePlate": "XHK1234",
                  "location": "350 Rhode Island St Ste. 400S, San Francisco, CA 94103",
                  "mechanicNotes": "Replaced headlight on passenger side.",
                  "odometerMeters": 14010293,
                  "safetyStatus": "safe",
                  "secondSignature": {
                    "signedAtTime": "2020-01-27T07:06:25.000Z"
                  },
                  "startTime": "2020-01-27T07:06:25.000Z",
                  "thirdSignature": {
                    "signedAtTime": "2020-01-27T07:06:25.000Z"
                  },
                  "trailer": {
                    "id": "123456789",
                    "name": "Midwest Trailer #5"
                  },
                  "trailerDefects": [
                    {
                      "comment": "Air Compressor not working",
                      "createdAtTime": "2020-01-27T07:06:25.000Z",
                      "defectType": "Air Compressor",
                      "id": "18",
                      "isResolved": true,
                      "mechanicNotes": "Extremely large oddly shaped hole in passenger side window.",
                      "mechanicNotesUpdatedAtTime": "2020-01-27T07:06:25.000Z",
                      "resolvedAtTime": "2020-01-27T07:06:25.000Z"
                    }
                  ],
                  "trailerName": "Midwest Trailer #5",
                  "type": "preTrip",
                  "vehicle": {
                    "ExternalIds": {
                      "maintenanceId": "250020",
                      "payrollId": "ABFS18600"
                    },
                    "id": "123456789",
                    "name": "Midwest Truck #4"
                  },
                  "vehicleDefects": [
                    {
                      "comment": "Air Compressor not working",
                      "createdAtTime": "2020-01-27T07:06:25.000Z",
                      "defectType": "Air Compressor",
                      "id": "18",
                      "isResolved": true,
                      "mechanicNotes": "Extremely large oddly shaped hole in passenger side window.",
                      "mechanicNotesUpdatedAtTime": "2020-01-27T07:06:25.000Z",
                      "resolvedAtTime": "2020-01-27T07:06:25.000Z"
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
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/fleet/dvirs/history")
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

        var response = await Client.LegacyApIs.GetDvirHistoryAsync(
            new GetDvirHistoryRequest { StartTime = "startTime", EndTime = "endTime" }
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<DvirsListResponse>(mockResponse)).UsingDefaults()
        );
    }
}
