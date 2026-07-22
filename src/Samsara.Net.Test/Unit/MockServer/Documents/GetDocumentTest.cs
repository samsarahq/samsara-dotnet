using NUnit.Framework;
using Samsara.Net.Documents;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.Documents;

[TestFixture]
public class GetDocumentTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": {
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
                  "externalIds": {
                    "key": "value"
                  },
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
                  "externalIds": {
                    "key": "value"
                  },
                  "id": "131313",
                  "name": "Pineapple delivery"
                },
                "routeStop": {
                  "externalIds": {
                    "key": "value"
                  },
                  "id": "494123",
                  "name": "Company Warehouse #1"
                },
                "state": "submitted",
                "updatedAtTime": "2001-01-20T14:48:23.000Z",
                "vehicle": {
                  "externalIds": {
                    "key": "value"
                  },
                  "id": "494123",
                  "name": "Fleet Truck #1"
                }
              }
            }
            """;

        Server
            .Given(
                WireMock.RequestBuilders.Request.Create().WithPath("/fleet/documents/id").UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Documents.GetDocumentAsync(
            new GetDocumentRequest { Id = "id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
