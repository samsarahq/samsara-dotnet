using NUnit.Framework;
using Samsara.Net.Issues;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.Issues;

[TestFixture]
public class GetIssuesStreamTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "asset": {
                    "entryType": "tracked",
                    "id": "281474982859091",
                    "name": "trailer 123"
                  },
                  "assignedTo": {
                    "id": "938172",
                    "type": "driver"
                  },
                  "createdAtTime": "2019-06-13T19:08:25.000Z",
                  "description": "Oil spill in left corner of SF1",
                  "dueDate": "2019-06-13T19:08:25.000Z",
                  "externalIds": {
                    "key": "value"
                  },
                  "id": "9814a1fa-f0c6-408b-bf85-51dc3bc71ac7",
                  "issueSource": {
                    "id": "9814a1fa-f0c6-408b-bf85-51dc3bc71ac7",
                    "type": "form"
                  },
                  "mediaList": [
                    {
                      "id": "9814a1fa-f0c6-408b-bf85-51dc3bc71ac7",
                      "processingStatus": "unknown",
                      "url": "https://samsara-forms-submission-media-uploads.s3.us-west-2.amazonaws.com/123456",
                      "urlExpiresAt": "2019-06-13T19:08:25.000Z"
                    }
                  ],
                  "priority": "low",
                  "status": "open",
                  "submittedAtTime": "2019-06-13T19:08:25.000Z",
                  "submittedBy": {
                    "id": "938172",
                    "type": "driver"
                  },
                  "title": "Oil spill",
                  "updatedAtTime": "2019-06-13T19:08:25.000Z"
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
                    .WithPath("/issues/stream")
                    .WithParam("startTime", "startTime")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Issues.GetIssuesStreamAsync(
            new GetIssuesStreamRequest { StartTime = "startTime" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
