using NUnit.Framework;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;
using Samsara.Net.WorkOrders;

namespace Samsara.Net.Test.Unit.MockServer.WorkOrders;

[TestFixture]
public class GetWorkOrdersTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "archivedAtTime": "2019-06-13T19:08:25.000Z",
                  "assetId": "12443",
                  "assignedUserId": "1234",
                  "attachments": [
                    {
                      "id": "9814a1fa-f0c6-408b-bf85-51dc3bc71ac7",
                      "processingStatus": "unknown",
                      "url": "https://samsara-forms-submission-media-uploads.s3.us-west-2.amazonaws.com/123456",
                      "urlExpiresAt": "2019-06-13T19:08:25.000Z"
                    }
                  ],
                  "category": "PREVENTIVE",
                  "closingNotes": "Everything was fixed without issues.",
                  "completedAtTime": "2019-06-13T19:08:25.000Z",
                  "createdAtTime": "2019-06-13T19:08:25.000Z",
                  "createdByUserId": "1234",
                  "description": "The vehicle is not starting.",
                  "discount": {
                    "basisPoints": 500,
                    "money": {
                      "amount": "94.01",
                      "currency": "usd"
                    }
                  },
                  "dueAtTime": "2019-06-13T19:08:25.000Z",
                  "engineHours": 91823,
                  "id": "5",
                  "invoiceNumber": "123456",
                  "items": [
                    {
                      "id": "9814a1fa-f0c6-408b-bf85-51dc3bc71ac7",
                      "type": "DVIR"
                    }
                  ],
                  "odometerMeters": 91823,
                  "poNumber": "123456",
                  "priority": "High",
                  "serviceTaskInstances": [
                    {
                      "id": "9814a1fa-f0c6-408b-bf85-51dc3bc71ac7",
                      "laborHourlyCost": {
                        "amount": "94.01",
                        "currency": "usd"
                      },
                      "laborTimeMinutes": 60,
                      "parts": [
                        {
                          "costCentsOverride": 1000,
                          "id": "9814a1fa-f0c6-408b-bf85-51dc3bc71ac7",
                          "partId": "P0077",
                          "quantity": 2.5
                        }
                      ],
                      "partsCost": {
                        "amount": "94.01",
                        "currency": "usd"
                      },
                      "serviceTaskId": "9814a1fa-f0c6-408b-bf85-51dc3bc71ac7",
                      "status": "Unknown"
                    }
                  ],
                  "status": "Assigned",
                  "tax": {
                    "basisPoints": 700,
                    "money": {
                      "amount": "94.01",
                      "currency": "usd"
                    }
                  },
                  "updatedAtTime": "2019-06-13T19:08:25.000Z",
                  "vendorUuid": "5523a39f-42ef-4820-83d0-dfe73dbe7853"
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
                    .WithPath("/maintenance/work-orders")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.WorkOrders.GetWorkOrdersAsync(new GetWorkOrdersRequest());
        JsonAssert.AreEqual(response, mockResponse);
    }
}
