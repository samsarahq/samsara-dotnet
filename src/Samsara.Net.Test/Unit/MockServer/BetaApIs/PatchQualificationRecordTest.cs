using System.Globalization;
using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.BetaApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class PatchQualificationRecordTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "id": "9814a1fa-f0c6-408b-bf85-51dc3bc71ac7",
              "issueDate": "2025-08-27T10:20:30.000Z",
              "owner": {
                "entityType": "worker",
                "id": "281474"
              }
            }
            """;

        const string mockResponse = """
            {
              "data": {
                "createdAtTime": "2019-06-13T19:08:25.000Z",
                "createdBy": {
                  "id": "938172",
                  "type": "driver"
                },
                "expirationDate": "2026-08-27T10:20:30.000Z",
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
                    "label": "License Number",
                    "mediaList": [
                      {
                        "id": "9814a1fa-f0c6-408b-bf85-51dc3bc71ac7",
                        "processingStatus": "unknown",
                        "url": "https://samsara-forms-submission-media-uploads.s3.us-west-2.amazonaws.com/123456",
                        "urlExpiresAt": "2019-06-13T19:08:25.000Z"
                      }
                    ],
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
                "id": "9814a1fa-f0c6-408b-bf85-51dc3bc71ac7",
                "issueDate": "2025-08-27T10:20:30.000Z",
                "owner": {
                  "entityType": "worker",
                  "externalIds": {
                    "key": "value"
                  },
                  "id": "281474"
                },
                "qualificationType": {
                  "id": "9814a1fa-f0c6-408b-bf85-51dc3bc71ac7",
                  "name": "Driver License",
                  "revisionId": "1214a1fa-f0c6-408b-bf85-51dc3bc71ac7"
                },
                "recordStatus": "active",
                "updatedAtTime": "2019-06-13T19:08:25.000Z",
                "updatedBy": {
                  "id": "938172",
                  "type": "driver"
                }
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/qualification-records")
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

        var response = await Client.BetaApIs.PatchQualificationRecordAsync(
            new QualificationsPatchQualificationRecordRequestBody
            {
                Id = "9814a1fa-f0c6-408b-bf85-51dc3bc71ac7",
                IssueDate = DateTime.Parse(
                    "2025-08-27T10:20:30.000Z",
                    null,
                    DateTimeStyles.AdjustToUniversal
                ),
                Owner = new QualificationOwnerRequestObjectRequestBody
                {
                    EntityType = QualificationOwnerRequestObjectRequestBodyEntityType.Worker,
                    Id = "281474",
                },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
