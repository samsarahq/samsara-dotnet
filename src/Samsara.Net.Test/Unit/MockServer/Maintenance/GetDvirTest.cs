using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.Core;
using Samsara.Net.Maintenance;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.Maintenance;

[TestFixture]
public class GetDvirTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "authorSignature": {
                "signatoryUser": {
                  "id": "938172"
                },
                "signedAtTime": "2020-01-27T07:06:25.000Z",
                "type": "driver"
              },
              "defectIds": [
                "8d218e6c-7a16-4f9f-90f7-cc1d93b9e596",
                "25d6151e-29b5-453e-875a-7c5425332e09"
              ],
              "dvirSubmissionBeginTime": "2020-01-27T07:06:25.000Z",
              "dvirSubmissionTime": "2020-01-27T07:06:25.000Z",
              "formattedAddress": "350 Rhode Island St Ste. 400S, San Francisco, CA 94103",
              "id": "12345",
              "mechanicNotes": "Replaced headlight on passenger side.",
              "odometerMeters": 91823,
              "safetyStatus": "unknown",
              "secondSignature": {
                "signatoryUser": {
                  "id": "938172"
                },
                "signedAtTime": "2020-01-27T07:06:25.000Z",
                "type": "driver"
              },
              "thirdSignature": {
                "signatoryUser": {
                  "id": "938172"
                },
                "signedAtTime": "2020-01-27T07:06:25.000Z",
                "type": "driver"
              },
              "trailer": {
                "externalIds": {
                  "key": "value"
                },
                "id": "494123"
              },
              "type": "preTrip",
              "updatedAtTime": "2020-01-27T07:06:25.000Z",
              "vehicle": {
                "externalIds": {
                  "key": "value"
                },
                "id": "494123"
              },
              "walkaroundPhotos": [
                {
                  "createdAtTime": "2020-01-27T07:06:25.000Z",
                  "name": "Name 1",
                  "url": "https://s3.samsara.com/samsara-driver-media-upload/walkaround-photo-path"
                }
              ]
            }
            """;

        Server
            .Given(WireMock.RequestBuilders.Request.Create().WithPath("/dvirs/id").UsingGet())
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Maintenance.GetDvirAsync(new GetDvirRequest { Id = "id" });
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<DvirGetDvirResponseBody>(mockResponse)).UsingDefaults()
        );
    }
}
