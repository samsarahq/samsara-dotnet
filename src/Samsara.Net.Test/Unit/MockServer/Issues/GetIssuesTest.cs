using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.Core;
using Samsara.Net.Issues;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.Issues;

[TestFixture]
public class GetIssuesTest : BaseMockServerTest
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
                    "externalIds": {
                      "externalIds": "externalIds"
                    },
                    "id": "id",
                    "name": "name"
                  },
                  "assignedTo": {
                    "id": "id",
                    "type": "driver"
                  },
                  "createdAtTime": "2024-01-15T09:30:00.000Z",
                  "description": "description",
                  "dueDate": "2024-01-15T09:30:00.000Z",
                  "externalIds": {
                    "externalIds": "externalIds"
                  },
                  "id": "id",
                  "issueSource": {
                    "id": "id",
                    "type": "form"
                  },
                  "mediaList": [
                    {
                      "id": "id",
                      "processingStatus": "unknown",
                      "url": "url",
                      "urlExpiresAt": "2024-01-15T09:30:00.000Z"
                    },
                    {
                      "id": "id",
                      "processingStatus": "unknown",
                      "url": "url",
                      "urlExpiresAt": "2024-01-15T09:30:00.000Z"
                    }
                  ],
                  "priority": "low",
                  "status": "open",
                  "submittedAtTime": "2024-01-15T09:30:00.000Z",
                  "submittedBy": {
                    "id": "id",
                    "type": "driver"
                  },
                  "title": "title",
                  "updatedAtTime": "2024-01-15T09:30:00.000Z"
                },
                {
                  "asset": {
                    "entryType": "tracked",
                    "externalIds": {
                      "externalIds": "externalIds"
                    },
                    "id": "id",
                    "name": "name"
                  },
                  "assignedTo": {
                    "id": "id",
                    "type": "driver"
                  },
                  "createdAtTime": "2024-01-15T09:30:00.000Z",
                  "description": "description",
                  "dueDate": "2024-01-15T09:30:00.000Z",
                  "externalIds": {
                    "externalIds": "externalIds"
                  },
                  "id": "id",
                  "issueSource": {
                    "id": "id",
                    "type": "form"
                  },
                  "mediaList": [
                    {
                      "id": "id",
                      "processingStatus": "unknown",
                      "url": "url",
                      "urlExpiresAt": "2024-01-15T09:30:00.000Z"
                    },
                    {
                      "id": "id",
                      "processingStatus": "unknown",
                      "url": "url",
                      "urlExpiresAt": "2024-01-15T09:30:00.000Z"
                    }
                  ],
                  "priority": "low",
                  "status": "open",
                  "submittedAtTime": "2024-01-15T09:30:00.000Z",
                  "submittedBy": {
                    "id": "id",
                    "type": "driver"
                  },
                  "title": "title",
                  "updatedAtTime": "2024-01-15T09:30:00.000Z"
                }
              ]
            }
            """;

        Server
            .Given(WireMock.RequestBuilders.Request.Create().WithPath("/issues").UsingGet())
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Issues.GetIssuesAsync(new GetIssuesRequest());
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<IssuesGetIssuesResponseBody>(mockResponse))
                .UsingDefaults()
        );
    }
}
