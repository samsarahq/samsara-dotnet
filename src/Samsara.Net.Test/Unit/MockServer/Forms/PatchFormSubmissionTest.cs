using NUnit.Framework;
using Samsara.Net.Forms;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.Forms;

[TestFixture]
public class PatchFormSubmissionTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "id": "9814a1fa-f0c6-408b-bf85-51dc3bc71ac8",
              "status": "notStarted"
            }
            """;

        const string mockResponse = """
            {
              "data": {
                "approvalDetails": {
                  "comment": "Requesting some changes to the submission."
                },
                "asset": {
                  "entryType": "tracked",
                  "externalIds": {
                    "key": "value"
                  },
                  "id": "281474982859091",
                  "name": "trailer 123"
                },
                "assignedAtTime": "2019-06-13T19:08:25.000Z",
                "assignedTo": {
                  "id": "938172",
                  "type": "driver"
                },
                "createdAtTime": "2019-06-13T19:08:25.000Z",
                "dueAtTime": "2019-06-13T19:08:25.000Z",
                "externalIds": {
                  "key": "value"
                },
                "fields": [
                  {
                    "checkBoxesValue": {
                      "value": [
                        "Option A",
                        "Option B"
                      ],
                      "valueIds": [
                        "0cbbddb3-2541-4889-b4eb-92171cbfc142",
                        "d33198cb-369f-4278-8120-d92d3ebf74bf"
                      ]
                    },
                    "dateTimeValue": {
                      "type": "datetime",
                      "value": "2024-08-08T18:53:23.000Z"
                    },
                    "id": "9814a1fa-f0c6-408b-bf85-51dc3bc71ac7",
                    "issue": {
                      "id": "12345"
                    },
                    "label": "Engine Hours",
                    "mediaList": [
                      {
                        "id": "9814a1fa-f0c6-408b-bf85-51dc3bc71ac7",
                        "processingStatus": "unknown",
                        "url": "https://samsara-forms-submission-media-uploads.s3.us-west-2.amazonaws.com/123456",
                        "urlExpiresAt": "2019-06-13T19:08:25.000Z"
                      }
                    ],
                    "mediaValue": {
                      "mediaList": [
                        {
                          "id": "9814a1fa-f0c6-408b-bf85-51dc3bc71ac7",
                          "processingStatus": "unknown",
                          "url": "https://samsara-forms-submission-media-uploads.s3.us-west-2.amazonaws.com/123456",
                          "urlExpiresAt": "2019-06-13T19:08:25.000Z"
                        }
                      ]
                    },
                    "multipleChoiceValue": {
                      "value": "Yes",
                      "valueId": "94096370-7228-4d83-ae5d-b20f3e45c0fc"
                    },
                    "note": "Fire and oil can lead to an accident.",
                    "numberValue": {
                      "value": 123.456
                    },
                    "signatureValue": {
                      "media": {
                        "id": "9814a1fa-f0c6-408b-bf85-51dc3bc71ac7",
                        "processingStatus": "unknown",
                        "url": "https://samsara-forms-submission-media-uploads.s3.us-west-2.amazonaws.com/123456",
                        "urlExpiresAt": "2019-06-13T19:08:25.000Z"
                      }
                    },
                    "tableValue": {
                      "columns": [
                        {
                          "id": "id",
                          "label": "Store Number",
                          "type": "text"
                        }
                      ],
                      "rows": [
                        {
                          "cells": [
                            {
                              "checkBoxesValue": {
                                "value": [
                                  "Option A",
                                  "Option B"
                                ],
                                "valueIds": [
                                  "0cbbddb3-2541-4889-b4eb-92171cbfc142",
                                  "d33198cb-369f-4278-8120-d92d3ebf74bf"
                                ]
                              },
                              "dateTimeValue": {
                                "type": "datetime",
                                "value": "2024-08-08T18:53:23.000Z"
                              },
                              "id": "id",
                              "mediaValue": {
                                "mediaList": [
                                  {
                                    "id": "9814a1fa-f0c6-408b-bf85-51dc3bc71ac7",
                                    "processingStatus": "unknown",
                                    "url": "https://samsara-forms-submission-media-uploads.s3.us-west-2.amazonaws.com/123456",
                                    "urlExpiresAt": "2019-06-13T19:08:25.000Z"
                                  }
                                ]
                              },
                              "multipleChoiceValue": {
                                "value": "Yes",
                                "valueId": "94096370-7228-4d83-ae5d-b20f3e45c0fc"
                              },
                              "numberValue": {
                                "value": 123.456
                              },
                              "signatureValue": {
                                "media": {
                                  "id": "9814a1fa-f0c6-408b-bf85-51dc3bc71ac7",
                                  "processingStatus": "unknown",
                                  "url": "https://samsara-forms-submission-media-uploads.s3.us-west-2.amazonaws.com/123456",
                                  "urlExpiresAt": "2019-06-13T19:08:25.000Z"
                                }
                              },
                              "textValue": {
                                "value": "Exposed wires"
                              },
                              "type": "number"
                            }
                          ],
                          "id": "id"
                        }
                      ]
                    },
                    "textValue": {
                      "value": "Exposed wires"
                    },
                    "type": "number"
                  }
                ],
                "formTemplate": {
                  "id": "9814a1fa-f0c6-408b-bf85-51dc3bc71ac7",
                  "revisionId": "1214a1fa-f0c6-408b-bf85-51dc3bc71ac7"
                },
                "geofence": {
                  "address": "123 Main St, Anytown, USA 12345",
                  "entryType": "tracked",
                  "externalIds": {
                    "key": "value"
                  },
                  "id": "1234567890",
                  "name": "Geofence Name"
                },
                "id": "9814a1fa-f0c6-408b-bf85-51dc3bc71ac7",
                "isRequired": true,
                "location": {
                  "latitude": 12333122.3,
                  "longitude": 1233331.4
                },
                "routeId": "123456789",
                "routeStopId": "987654321",
                "score": {
                  "maxPoints": 80,
                  "scorePercent": 75,
                  "scorePoints": 60
                },
                "status": "notStarted",
                "submittedAtTime": "2019-06-13T19:08:25.000Z",
                "submittedBy": {
                  "id": "938172",
                  "type": "driver"
                },
                "title": "Form Submission Title",
                "updatedAtTime": "2019-06-13T19:08:25.000Z"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/form-submissions")
                    .WithHeader("Content-Type", "application/json")
                    .UsingPatch()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Forms.PatchFormSubmissionAsync(
            new FormSubmissionsPatchFormSubmissionRequestBody
            {
                Id = "9814a1fa-f0c6-408b-bf85-51dc3bc71ac8",
                Status = FormSubmissionsPatchFormSubmissionRequestBodyStatus.NotStarted,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
