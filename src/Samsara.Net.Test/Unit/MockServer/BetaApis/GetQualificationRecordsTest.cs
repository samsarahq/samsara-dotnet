using NUnit.Framework;
using Samsara.Net.BetaApis;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApis;

[TestFixture]
public class GetQualificationRecordsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "createdAtTime": "2024-01-15T09:30:00.000Z",
                  "createdBy": {
                    "id": "id",
                    "type": "driver"
                  },
                  "expirationDate": "2024-01-15T09:30:00.000Z",
                  "externalIds": {
                    "externalIds": "externalIds"
                  },
                  "fields": [
                    {
                      "checkBoxesValue": {
                        "value": [
                          "value",
                          "value"
                        ],
                        "valueIds": [
                          "valueIds",
                          "valueIds"
                        ]
                      },
                      "dateTimeValue": {
                        "type": "datetime",
                        "value": "2024-01-15T09:30:00.000Z"
                      },
                      "id": "id",
                      "label": "label",
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
                      "multipleChoiceValue": {
                        "value": "value",
                        "valueId": "valueId"
                      },
                      "numberValue": {
                        "value": 1.1
                      },
                      "signatureValue": {
                        "media": {
                          "id": "id",
                          "processingStatus": "unknown",
                          "url": "url",
                          "urlExpiresAt": "2024-01-15T09:30:00.000Z"
                        }
                      },
                      "tableValue": {
                        "columns": [
                          {
                            "id": "id",
                            "label": "label",
                            "type": "text"
                          },
                          {
                            "id": "id",
                            "label": "label",
                            "type": "text"
                          }
                        ],
                        "rows": [
                          {
                            "cells": [],
                            "id": "id"
                          },
                          {
                            "cells": [],
                            "id": "id"
                          }
                        ]
                      },
                      "textValue": {
                        "value": "value"
                      },
                      "type": "number"
                    },
                    {
                      "checkBoxesValue": {
                        "value": [
                          "value",
                          "value"
                        ],
                        "valueIds": [
                          "valueIds",
                          "valueIds"
                        ]
                      },
                      "dateTimeValue": {
                        "type": "datetime",
                        "value": "2024-01-15T09:30:00.000Z"
                      },
                      "id": "id",
                      "label": "label",
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
                      "multipleChoiceValue": {
                        "value": "value",
                        "valueId": "valueId"
                      },
                      "numberValue": {
                        "value": 1.1
                      },
                      "signatureValue": {
                        "media": {
                          "id": "id",
                          "processingStatus": "unknown",
                          "url": "url",
                          "urlExpiresAt": "2024-01-15T09:30:00.000Z"
                        }
                      },
                      "tableValue": {
                        "columns": [
                          {
                            "id": "id",
                            "label": "label",
                            "type": "text"
                          },
                          {
                            "id": "id",
                            "label": "label",
                            "type": "text"
                          }
                        ],
                        "rows": [
                          {
                            "cells": [],
                            "id": "id"
                          },
                          {
                            "cells": [],
                            "id": "id"
                          }
                        ]
                      },
                      "textValue": {
                        "value": "value"
                      },
                      "type": "number"
                    }
                  ],
                  "id": "id",
                  "issueDate": "2024-01-15T09:30:00.000Z",
                  "owner": {
                    "entityType": "worker",
                    "externalIds": {
                      "externalIds": "externalIds"
                    },
                    "id": "id"
                  },
                  "qualificationType": {
                    "id": "id",
                    "name": "name",
                    "revisionId": "revisionId"
                  },
                  "recordStatus": "active",
                  "updatedAtTime": "2024-01-15T09:30:00.000Z",
                  "updatedBy": {
                    "id": "id",
                    "type": "driver"
                  }
                },
                {
                  "createdAtTime": "2024-01-15T09:30:00.000Z",
                  "createdBy": {
                    "id": "id",
                    "type": "driver"
                  },
                  "expirationDate": "2024-01-15T09:30:00.000Z",
                  "externalIds": {
                    "externalIds": "externalIds"
                  },
                  "fields": [
                    {
                      "checkBoxesValue": {
                        "value": [
                          "value",
                          "value"
                        ],
                        "valueIds": [
                          "valueIds",
                          "valueIds"
                        ]
                      },
                      "dateTimeValue": {
                        "type": "datetime",
                        "value": "2024-01-15T09:30:00.000Z"
                      },
                      "id": "id",
                      "label": "label",
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
                      "multipleChoiceValue": {
                        "value": "value",
                        "valueId": "valueId"
                      },
                      "numberValue": {
                        "value": 1.1
                      },
                      "signatureValue": {
                        "media": {
                          "id": "id",
                          "processingStatus": "unknown",
                          "url": "url",
                          "urlExpiresAt": "2024-01-15T09:30:00.000Z"
                        }
                      },
                      "tableValue": {
                        "columns": [
                          {
                            "id": "id",
                            "label": "label",
                            "type": "text"
                          },
                          {
                            "id": "id",
                            "label": "label",
                            "type": "text"
                          }
                        ],
                        "rows": [
                          {
                            "cells": [],
                            "id": "id"
                          },
                          {
                            "cells": [],
                            "id": "id"
                          }
                        ]
                      },
                      "textValue": {
                        "value": "value"
                      },
                      "type": "number"
                    },
                    {
                      "checkBoxesValue": {
                        "value": [
                          "value",
                          "value"
                        ],
                        "valueIds": [
                          "valueIds",
                          "valueIds"
                        ]
                      },
                      "dateTimeValue": {
                        "type": "datetime",
                        "value": "2024-01-15T09:30:00.000Z"
                      },
                      "id": "id",
                      "label": "label",
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
                      "multipleChoiceValue": {
                        "value": "value",
                        "valueId": "valueId"
                      },
                      "numberValue": {
                        "value": 1.1
                      },
                      "signatureValue": {
                        "media": {
                          "id": "id",
                          "processingStatus": "unknown",
                          "url": "url",
                          "urlExpiresAt": "2024-01-15T09:30:00.000Z"
                        }
                      },
                      "tableValue": {
                        "columns": [
                          {
                            "id": "id",
                            "label": "label",
                            "type": "text"
                          },
                          {
                            "id": "id",
                            "label": "label",
                            "type": "text"
                          }
                        ],
                        "rows": [
                          {
                            "cells": [],
                            "id": "id"
                          },
                          {
                            "cells": [],
                            "id": "id"
                          }
                        ]
                      },
                      "textValue": {
                        "value": "value"
                      },
                      "type": "number"
                    }
                  ],
                  "id": "id",
                  "issueDate": "2024-01-15T09:30:00.000Z",
                  "owner": {
                    "entityType": "worker",
                    "externalIds": {
                      "externalIds": "externalIds"
                    },
                    "id": "id"
                  },
                  "qualificationType": {
                    "id": "id",
                    "name": "name",
                    "revisionId": "revisionId"
                  },
                  "recordStatus": "active",
                  "updatedAtTime": "2024-01-15T09:30:00.000Z",
                  "updatedBy": {
                    "id": "id",
                    "type": "driver"
                  }
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/qualification-records")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.BetaApis.GetQualificationRecordsAsync(
            new GetQualificationRecordsRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
