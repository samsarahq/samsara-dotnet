using NUnit.Framework;
using Samsara.Net.BetaApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class GetCampaignsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "campaignNumber": "26S38",
                  "campaignType": "safetyRecall",
                  "createdAtTime": "2026-01-20T15:04:05.000Z",
                  "createdSource": "dashboard",
                  "description": "Replace rear brake hose per OEM bulletin.",
                  "endTime": "2026-08-01T00:00:00.000Z",
                  "id": "2d0e5e9b-4b2a-4e4e-9b8e-6c3f8a7d1e2f",
                  "isWarranty": true,
                  "name": "Rear brake hose recall",
                  "recallMetadata": {
                    "nhtsaRecallNumber": "24V-123",
                    "oemNotificationTime": "2026-01-15T00:00:00.000Z",
                    "oemRecallNumber": "26S38",
                    "ownerNotificationTime": "2026-02-01T00:00:00.000Z",
                    "partsAvailableTime": "2026-03-01T00:00:00.000Z",
                    "recallSource": "recallMasters",
                    "remedyAvailableTime": "2026-03-01T00:00:00.000Z",
                    "supersededByRecallNumber": "26S40"
                  },
                  "startTime": "2026-02-01T00:00:00.000Z",
                  "status": {
                    "id": "f6e83fa8-c1fb-5d15-8832-693161b9c6e7",
                    "name": "Draft",
                    "state": "draft"
                  },
                  "updatedAtTime": "2026-01-21T09:30:00.000Z",
                  "workOrderPriority": "High",
                  "workOrderTemplateId": "5523a39f-42ef-4820-83d0-dfe73dbe7853"
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
                    .WithPath("/maintenance/campaigns")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.BetaApIs.GetCampaignsAsync(new GetCampaignsRequest());
        JsonAssert.AreEqual(response, mockResponse);
    }
}
