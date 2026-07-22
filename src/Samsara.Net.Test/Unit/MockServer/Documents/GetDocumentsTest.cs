using NUnit.Framework;
using Samsara.Net.Documents;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.Documents;

[TestFixture]
public class GetDocumentsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "conditionalFieldSections": [
                    {
                      "conditionalFieldFirstIndex": 2529239247727561700,
                      "conditionalFieldLastIndex": 5262110667266989000,
                      "triggeringFieldIndex": 1302825110937476600,
                      "triggeringFieldValue": "Optiona 1"
                    }
                  ],
                  "createdAtTime": "1997-05-08T01:03:55.000Z",
                  "documentType": {
                    "id": "9814a1fa-f0c6-408b-bf85-51dc3bc71ac7",
                    "name": "Fleet Truck List"
                  },
                  "driver": {
                    "id": "45646",
                    "name": "Driver Bob"
                  },
                  "fields": [
                    {
                      "label": "Load weight",
                      "type": "photo",
                      "value": {
                        "numberValue": 123.456,
                        "stringValue": "Red Truck"
                      }
                    }
                  ],
                  "id": "9814a1fa-f0c6-408b-bf85-51dc3bc71ac7",
                  "name": "Dropoff Slip 123",
                  "notes": "Missing a crate",
                  "route": {
                    "id": "131313",
                    "name": "Pineapple delivery"
                  },
                  "routeStop": {
                    "id": "494123",
                    "name": "Company Warehouse #1"
                  },
                  "state": "submitted",
                  "updatedAtTime": "2001-01-20T14:48:23.000Z",
                  "vehicle": {
                    "id": "494123",
                    "name": "Fleet Truck #1"
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
                    .WithPath("/fleet/documents")
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

        var response = await Client.Documents.GetDocumentsAsync(
            new GetDocumentsRequest { StartTime = "startTime", EndTime = "endTime" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
