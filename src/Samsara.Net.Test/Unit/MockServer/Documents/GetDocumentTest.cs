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
                    "conditionalFieldFirstIndex": 7614788251245023000,
                    "conditionalFieldLastIndex": 4183211541072084000,
                    "triggeringFieldIndex": 4033010555242500600,
                    "triggeringFieldValue": "Optiona 1"
                  }
                ],
                "createdAtTime": "2009-03-03T07:48:13.000Z",
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
                "updatedAtTime": "1992-02-28T12:42:58.000Z",
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
