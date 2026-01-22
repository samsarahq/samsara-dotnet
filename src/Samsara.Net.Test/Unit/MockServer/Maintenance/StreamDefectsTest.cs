using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.Core;
using Samsara.Net.Maintenance;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.Maintenance;

[TestFixture]
public class StreamDefectsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "comment": "Engine failure.",
                  "createdAtTime": "2020-01-27T07:06:25.000Z",
                  "defectPhotos": [
                    {
                      "createdAtTime": "2020-01-27T07:06:25.000Z",
                      "url": "https://s3.samsara.com/samsara-driver-media-upload/defect-photo-path"
                    }
                  ],
                  "defectTypeId": "25d6151e-29b5-453e-875a-7c5425332e09",
                  "dvirId": "292371177",
                  "id": "9700544",
                  "isResolved": true,
                  "mechanicNotes": "Broken passenger side window.",
                  "resolvedAtTime": "2020-01-27T07:06:25.000Z",
                  "resolvedBy": {
                    "id": "8172",
                    "name": "Jane Mechanic",
                    "type": "driver"
                  },
                  "trailer": {
                    "id": "494123"
                  },
                  "updatedAtTime": "2020-01-27T07:06:25.000Z",
                  "vehicle": {
                    "id": "494125"
                  }
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
                    .WithPath("/defects/stream")
                    .WithParam("startTime", "startTime")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Maintenance.StreamDefectsAsync(
            new StreamDefectsRequest { StartTime = "startTime" }
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<DvirDefectStreamDefectsResponseBody>(mockResponse))
                .UsingDefaults()
        );
    }
}
