using NUnit.Framework;
using Samsara.Net.Maintenance;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.Maintenance;

[TestFixture]
public class GetDvirsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "authorSignature": {
                    "signatoryUser": {
                      "id": "938172"
                    },
                    "signedAtTime": "2020-01-27T07:06:25Z",
                    "type": "driver"
                  },
                  "defectIds": [
                    "8d218e6c-7a16-4f9f-90f7-cc1d93b9e596",
                    "25d6151e-29b5-453e-875a-7c5425332e09"
                  ],
                  "dvirSubmissionBeginTime": "2020-01-27T07:06:25Z",
                  "dvirSubmissionTime": "2020-01-27T07:06:25Z",
                  "formattedAddress": "350 Rhode Island St Ste. 400S, San Francisco, CA 94103",
                  "id": "12345",
                  "mechanicNotes": "Replaced headlight on passenger side.",
                  "odometerMeters": 91823,
                  "safetyStatus": "unknown",
                  "secondSignature": {
                    "signatoryUser": {
                      "id": "938172"
                    },
                    "signedAtTime": "2020-01-27T07:06:25Z",
                    "type": "driver"
                  },
                  "thirdSignature": {
                    "signatoryUser": {
                      "id": "938172"
                    },
                    "signedAtTime": "2020-01-27T07:06:25Z",
                    "type": "driver"
                  },
                  "trailer": {
                    "id": "494123"
                  },
                  "type": "preTrip",
                  "updatedAtTime": "2020-01-27T07:06:25Z",
                  "vehicle": {
                    "id": "494123"
                  },
                  "walkaroundPhotos": [
                    {
                      "createdAtTime": "2020-01-27T07:06:25Z",
                      "name": "Name 1",
                      "url": "https://s3.samsara.com/samsara-driver-media-upload/walkaround-photo-path"
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
                    .WithPath("/dvirs/stream")
                    .WithParam("startTime", "startTime")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Maintenance.GetDvirsAsync(
            new GetDvirsRequest { StartTime = "startTime" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
