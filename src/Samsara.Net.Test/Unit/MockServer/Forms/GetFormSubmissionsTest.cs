using NUnit.Framework;
using Samsara.Net.Forms;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.Forms;

[TestFixture]
public class GetFormSubmissionsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "approvalDetails": {
                    "comment": "comment"
                  },
                  "asset": {
                    "entryType": "tracked",
                    "externalIds": {
                      "externalIds": "externalIds"
                    },
                    "id": "id",
                    "name": "name"
                  },
                  "assignedAtTime": "2024-01-15T09:30:00.000Z",
                  "assignedTo": {
                    "id": "id",
                    "type": "driver"
                  },
                  "createdAtTime": "2024-01-15T09:30:00.000Z",
                  "dueAtTime": "2024-01-15T09:30:00.000Z",
                  "externalIds": {
                    "externalIds": "externalIds"
                  },
                  "fields": [
                    {
                      "assetValue": {
                        "asset": {
                          "entryType": "tracked",
                          "externalIds": {
                            "externalIds": "externalIds"
                          },
                          "id": "id",
                          "name": "name"
                        }
                      },
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
                      "geofenceValue": {
                        "geofence": {
                          "address": "address",
                          "entryType": "tracked",
                          "externalIds": {
                            "externalIds": "externalIds"
                          },
                          "id": "id",
                          "name": "name"
                        }
                      },
                      "id": "id",
                      "issue": {
                        "externalIds": {
                          "externalIds": "externalIds"
                        },
                        "id": "id"
                      },
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
                      "mediaValue": {
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
                        ]
                      },
                      "multipleChoiceValue": {
                        "value": "value",
                        "valueId": "valueId"
                      },
                      "note": "note",
                      "numberValue": {
                        "value": 1.1
                      },
                      "personValue": {
                        "person": {
                          "entryType": "tracked",
                          "name": "name",
                          "polymorphicUserId": {
                            "id": "id",
                            "type": "driver"
                          }
                        }
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
                      "assetValue": {
                        "asset": {
                          "entryType": "tracked",
                          "externalIds": {
                            "externalIds": "externalIds"
                          },
                          "id": "id",
                          "name": "name"
                        }
                      },
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
                      "geofenceValue": {
                        "geofence": {
                          "address": "address",
                          "entryType": "tracked",
                          "externalIds": {
                            "externalIds": "externalIds"
                          },
                          "id": "id",
                          "name": "name"
                        }
                      },
                      "id": "id",
                      "issue": {
                        "externalIds": {
                          "externalIds": "externalIds"
                        },
                        "id": "id"
                      },
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
                      "mediaValue": {
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
                        ]
                      },
                      "multipleChoiceValue": {
                        "value": "value",
                        "valueId": "valueId"
                      },
                      "note": "note",
                      "numberValue": {
                        "value": 1.1
                      },
                      "personValue": {
                        "person": {
                          "entryType": "tracked",
                          "name": "name",
                          "polymorphicUserId": {
                            "id": "id",
                            "type": "driver"
                          }
                        }
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
                  "formTemplate": {
                    "id": "id",
                    "revisionId": "revisionId"
                  },
                  "geofence": {
                    "address": "address",
                    "entryType": "tracked",
                    "externalIds": {
                      "externalIds": "externalIds"
                    },
                    "id": "id",
                    "name": "name"
                  },
                  "id": "id",
                  "isRequired": true,
                  "location": {
                    "latitude": 1.1,
                    "longitude": 1.1
                  },
                  "routeId": "routeId",
                  "routeStopId": "routeStopId",
                  "score": {
                    "maxPoints": 1.1,
                    "scorePercent": 1.1,
                    "scorePoints": 1.1
                  },
                  "status": "notStarted",
                  "submittedAtTime": "2024-01-15T09:30:00.000Z",
                  "submittedBy": {
                    "id": "id",
                    "type": "driver"
                  },
                  "title": "title",
                  "updatedAtTime": "2024-01-15T09:30:00.000Z"
                },
                {
                  "approvalDetails": {
                    "comment": "comment"
                  },
                  "asset": {
                    "entryType": "tracked",
                    "externalIds": {
                      "externalIds": "externalIds"
                    },
                    "id": "id",
                    "name": "name"
                  },
                  "assignedAtTime": "2024-01-15T09:30:00.000Z",
                  "assignedTo": {
                    "id": "id",
                    "type": "driver"
                  },
                  "createdAtTime": "2024-01-15T09:30:00.000Z",
                  "dueAtTime": "2024-01-15T09:30:00.000Z",
                  "externalIds": {
                    "externalIds": "externalIds"
                  },
                  "fields": [
                    {
                      "assetValue": {
                        "asset": {
                          "entryType": "tracked",
                          "externalIds": {
                            "externalIds": "externalIds"
                          },
                          "id": "id",
                          "name": "name"
                        }
                      },
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
                      "geofenceValue": {
                        "geofence": {
                          "address": "address",
                          "entryType": "tracked",
                          "externalIds": {
                            "externalIds": "externalIds"
                          },
                          "id": "id",
                          "name": "name"
                        }
                      },
                      "id": "id",
                      "issue": {
                        "externalIds": {
                          "externalIds": "externalIds"
                        },
                        "id": "id"
                      },
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
                      "mediaValue": {
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
                        ]
                      },
                      "multipleChoiceValue": {
                        "value": "value",
                        "valueId": "valueId"
                      },
                      "note": "note",
                      "numberValue": {
                        "value": 1.1
                      },
                      "personValue": {
                        "person": {
                          "entryType": "tracked",
                          "name": "name",
                          "polymorphicUserId": {
                            "id": "id",
                            "type": "driver"
                          }
                        }
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
                      "assetValue": {
                        "asset": {
                          "entryType": "tracked",
                          "externalIds": {
                            "externalIds": "externalIds"
                          },
                          "id": "id",
                          "name": "name"
                        }
                      },
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
                      "geofenceValue": {
                        "geofence": {
                          "address": "address",
                          "entryType": "tracked",
                          "externalIds": {
                            "externalIds": "externalIds"
                          },
                          "id": "id",
                          "name": "name"
                        }
                      },
                      "id": "id",
                      "issue": {
                        "externalIds": {
                          "externalIds": "externalIds"
                        },
                        "id": "id"
                      },
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
                      "mediaValue": {
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
                        ]
                      },
                      "multipleChoiceValue": {
                        "value": "value",
                        "valueId": "valueId"
                      },
                      "note": "note",
                      "numberValue": {
                        "value": 1.1
                      },
                      "personValue": {
                        "person": {
                          "entryType": "tracked",
                          "name": "name",
                          "polymorphicUserId": {
                            "id": "id",
                            "type": "driver"
                          }
                        }
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
                  "formTemplate": {
                    "id": "id",
                    "revisionId": "revisionId"
                  },
                  "geofence": {
                    "address": "address",
                    "entryType": "tracked",
                    "externalIds": {
                      "externalIds": "externalIds"
                    },
                    "id": "id",
                    "name": "name"
                  },
                  "id": "id",
                  "isRequired": true,
                  "location": {
                    "latitude": 1.1,
                    "longitude": 1.1
                  },
                  "routeId": "routeId",
                  "routeStopId": "routeStopId",
                  "score": {
                    "maxPoints": 1.1,
                    "scorePercent": 1.1,
                    "scorePoints": 1.1
                  },
                  "status": "notStarted",
                  "submittedAtTime": "2024-01-15T09:30:00.000Z",
                  "submittedBy": {
                    "id": "id",
                    "type": "driver"
                  },
                  "title": "title",
                  "updatedAtTime": "2024-01-15T09:30:00.000Z"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock.RequestBuilders.Request.Create().WithPath("/form-submissions").UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Forms.GetFormSubmissionsAsync(new GetFormSubmissionsRequest());
        JsonAssert.AreEqual(response, mockResponse);
    }
}
