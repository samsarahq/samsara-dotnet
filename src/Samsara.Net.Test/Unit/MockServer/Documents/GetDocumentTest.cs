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
                    "conditionalFieldFirstIndex": 8217465358527716000,
                    "conditionalFieldLastIndex": 1543582388420605000,
                    "triggeringFieldIndex": 7540159348423735000,
                    "triggeringFieldValue": "Optiona 1"
                  }
                ],
                "createdAtTime": "2014-09-02T18:11:09.000Z",
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
                "updatedAtTime": "1980-08-29T21:44:37.000Z",
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
