using NUnit.Framework;
using Samsara.Net.Documents;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.Documents;

[TestFixture]
public class PostDocumentTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "documentTypeId": "9814a1fa-f0c6-408b-bf85-51dc3bc71ac7",
              "driverId": "45646"
            }
            """;

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
                "createdAtTime": "2015-09-08T06:33:15.000Z",
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
                      "barcodeValue": [
                        {
                          "barcodeType": "org.gs1.EAN-13",
                          "barcodeValue": "0853883003114"
                        }
                      ],
                      "dateTimeValue": {
                        "dateTime": "1973-12-20T17:06:49.000Z"
                      },
                      "multipleChoiceValue": [
                        {
                          "selected": false,
                          "value": "Yes"
                        }
                      ],
                      "numberValue": 123.456,
                      "photoValue": [
                        {
                          "id": "f5271458-21f9-4a9f-a290-780c6d8840ff",
                          "url": "https://samsara-driver-media-upload.s3.us-west-2.amazonaws.com/123456"
                        }
                      ],
                      "scannedDocumentValue": [
                        {
                          "id": "f5271458-21f9-4a9f-a290-780c6d8840ff",
                          "url": "https://samsara-driver-media-upload.s3.us-west-2.amazonaws.com/123456"
                        }
                      ],
                      "signatureValue": {
                        "id": "9814a1fa-f0c6-408b-bf85-51dc3bc71ac7",
                        "name": "John Smith",
                        "signedAtTime": "1989-09-25T02:38:09.000Z",
                        "url": "https://samsara-driver-media-upload.s3.us-west-2.amazonaws.com/123456"
                      },
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
                "updatedAtTime": "1975-05-20T03:23:39.000Z",
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
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/fleet/documents")
                    .WithHeader("Content-Type", "application/json")
                    .UsingPost()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Documents.PostDocumentAsync(
            new DocumentsPostDocumentRequestBody
            {
                DocumentTypeId = "9814a1fa-f0c6-408b-bf85-51dc3bc71ac7",
                DriverId = "45646",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
