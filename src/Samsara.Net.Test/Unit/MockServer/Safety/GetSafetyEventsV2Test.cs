using NUnit.Framework;
using Samsara.Net.Safety;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.Safety;

[TestFixture]
public class GetSafetyEventsV2Test : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "asset": {
                    "attributes": [
                      {
                        "dateValues": [
                          "dateValues",
                          "dateValues"
                        ],
                        "id": "id",
                        "name": "name",
                        "numberValues": [
                          1.1,
                          1.1
                        ],
                        "stringValues": [
                          "stringValues",
                          "stringValues"
                        ]
                      },
                      {
                        "dateValues": [
                          "dateValues",
                          "dateValues"
                        ],
                        "id": "id",
                        "name": "name",
                        "numberValues": [
                          1.1,
                          1.1
                        ],
                        "stringValues": [
                          "stringValues",
                          "stringValues"
                        ]
                      }
                    ],
                    "externalIds": {
                      "externalIds": "externalIds"
                    },
                    "id": "id",
                    "name": "name",
                    "tags": [
                      {
                        "id": "id",
                        "name": "name",
                        "parentTagId": "parentTagId"
                      },
                      {
                        "id": "id",
                        "name": "name",
                        "parentTagId": "parentTagId"
                      }
                    ],
                    "type": "uncategorized",
                    "vin": "vin"
                  },
                  "assignedCoach": "assignedCoach",
                  "behaviorLabels": [
                    {
                      "label": "Acceleration",
                      "source": "automated"
                    },
                    {
                      "label": "Acceleration",
                      "source": "automated"
                    }
                  ],
                  "contextLabels": [
                    {
                      "authorId": "authorId",
                      "createdAtTime": "createdAtTime",
                      "name": "name"
                    },
                    {
                      "authorId": "authorId",
                      "createdAtTime": "createdAtTime",
                      "name": "name"
                    }
                  ],
                  "createdAtTime": "createdAtTime",
                  "detectedStreams": [
                    {
                      "auxcamSerial": "auxcamSerial",
                      "cameraRole": "leftMirrorMount",
                      "input": "dashcamRoadFacing",
                      "url": "url"
                    },
                    {
                      "auxcamSerial": "auxcamSerial",
                      "cameraRole": "leftMirrorMount",
                      "input": "dashcamRoadFacing",
                      "url": "url"
                    }
                  ],
                  "dismissalReason": {
                    "code": "incorrect",
                    "comment": "comment"
                  },
                  "driver": {
                    "attributes": [
                      {
                        "dateValues": [
                          "dateValues",
                          "dateValues"
                        ],
                        "id": "id",
                        "name": "name",
                        "numberValues": [
                          1.1,
                          1.1
                        ],
                        "stringValues": [
                          "stringValues",
                          "stringValues"
                        ]
                      },
                      {
                        "dateValues": [
                          "dateValues",
                          "dateValues"
                        ],
                        "id": "id",
                        "name": "name",
                        "numberValues": [
                          1.1,
                          1.1
                        ],
                        "stringValues": [
                          "stringValues",
                          "stringValues"
                        ]
                      }
                    ],
                    "externalIds": {
                      "externalIds": "externalIds"
                    },
                    "id": "id",
                    "name": "name",
                    "tags": [
                      {
                        "id": "id",
                        "name": "name",
                        "parentTagId": "parentTagId"
                      },
                      {
                        "id": "id",
                        "name": "name",
                        "parentTagId": "parentTagId"
                      }
                    ]
                  },
                  "endMs": "endMs",
                  "eventState": "unknown",
                  "id": "id",
                  "inboxEventUrl": "inboxEventUrl",
                  "incidentReportUrl": "incidentReportUrl",
                  "location": {
                    "accuracyMeters": 1.1,
                    "address": {
                      "city": "city",
                      "country": "country",
                      "neighborhood": "neighborhood",
                      "pointOfInterest": "pointOfInterest",
                      "postalCode": "postalCode",
                      "state": "state",
                      "street": "street",
                      "streetNumber": "streetNumber"
                    },
                    "geofence": {
                      "externalIds": {
                        "externalIds": "externalIds"
                      },
                      "id": "id"
                    },
                    "headingDegrees": 1000000,
                    "latitude": 1.1,
                    "longitude": 1.1
                  },
                  "maxAccelerationGForce": 1.1,
                  "media": [
                    {
                      "auxcamSerial": "auxcamSerial",
                      "cameraRole": "leftMirrorMount",
                      "input": "dashcamRoadFacing",
                      "url": "url"
                    },
                    {
                      "auxcamSerial": "auxcamSerial",
                      "cameraRole": "leftMirrorMount",
                      "input": "dashcamRoadFacing",
                      "url": "url"
                    }
                  ],
                  "speedingMetadata": {
                    "maxSpeedKilometersPerHour": 1000000,
                    "postedSpeedLimitKilometersPerHour": 1000000
                  },
                  "startMs": "startMs",
                  "tripEndTime": "tripEndTime",
                  "tripStartTime": "tripStartTime",
                  "updatedAtTime": "updatedAtTime",
                  "updatedByUserId": "updatedByUserId"
                },
                {
                  "asset": {
                    "attributes": [
                      {
                        "dateValues": [
                          "dateValues",
                          "dateValues"
                        ],
                        "id": "id",
                        "name": "name",
                        "numberValues": [
                          1.1,
                          1.1
                        ],
                        "stringValues": [
                          "stringValues",
                          "stringValues"
                        ]
                      },
                      {
                        "dateValues": [
                          "dateValues",
                          "dateValues"
                        ],
                        "id": "id",
                        "name": "name",
                        "numberValues": [
                          1.1,
                          1.1
                        ],
                        "stringValues": [
                          "stringValues",
                          "stringValues"
                        ]
                      }
                    ],
                    "externalIds": {
                      "externalIds": "externalIds"
                    },
                    "id": "id",
                    "name": "name",
                    "tags": [
                      {
                        "id": "id",
                        "name": "name",
                        "parentTagId": "parentTagId"
                      },
                      {
                        "id": "id",
                        "name": "name",
                        "parentTagId": "parentTagId"
                      }
                    ],
                    "type": "uncategorized",
                    "vin": "vin"
                  },
                  "assignedCoach": "assignedCoach",
                  "behaviorLabels": [
                    {
                      "label": "Acceleration",
                      "source": "automated"
                    },
                    {
                      "label": "Acceleration",
                      "source": "automated"
                    }
                  ],
                  "contextLabels": [
                    {
                      "authorId": "authorId",
                      "createdAtTime": "createdAtTime",
                      "name": "name"
                    },
                    {
                      "authorId": "authorId",
                      "createdAtTime": "createdAtTime",
                      "name": "name"
                    }
                  ],
                  "createdAtTime": "createdAtTime",
                  "detectedStreams": [
                    {
                      "auxcamSerial": "auxcamSerial",
                      "cameraRole": "leftMirrorMount",
                      "input": "dashcamRoadFacing",
                      "url": "url"
                    },
                    {
                      "auxcamSerial": "auxcamSerial",
                      "cameraRole": "leftMirrorMount",
                      "input": "dashcamRoadFacing",
                      "url": "url"
                    }
                  ],
                  "dismissalReason": {
                    "code": "incorrect",
                    "comment": "comment"
                  },
                  "driver": {
                    "attributes": [
                      {
                        "dateValues": [
                          "dateValues",
                          "dateValues"
                        ],
                        "id": "id",
                        "name": "name",
                        "numberValues": [
                          1.1,
                          1.1
                        ],
                        "stringValues": [
                          "stringValues",
                          "stringValues"
                        ]
                      },
                      {
                        "dateValues": [
                          "dateValues",
                          "dateValues"
                        ],
                        "id": "id",
                        "name": "name",
                        "numberValues": [
                          1.1,
                          1.1
                        ],
                        "stringValues": [
                          "stringValues",
                          "stringValues"
                        ]
                      }
                    ],
                    "externalIds": {
                      "externalIds": "externalIds"
                    },
                    "id": "id",
                    "name": "name",
                    "tags": [
                      {
                        "id": "id",
                        "name": "name",
                        "parentTagId": "parentTagId"
                      },
                      {
                        "id": "id",
                        "name": "name",
                        "parentTagId": "parentTagId"
                      }
                    ]
                  },
                  "endMs": "endMs",
                  "eventState": "unknown",
                  "id": "id",
                  "inboxEventUrl": "inboxEventUrl",
                  "incidentReportUrl": "incidentReportUrl",
                  "location": {
                    "accuracyMeters": 1.1,
                    "address": {
                      "city": "city",
                      "country": "country",
                      "neighborhood": "neighborhood",
                      "pointOfInterest": "pointOfInterest",
                      "postalCode": "postalCode",
                      "state": "state",
                      "street": "street",
                      "streetNumber": "streetNumber"
                    },
                    "geofence": {
                      "externalIds": {
                        "externalIds": "externalIds"
                      },
                      "id": "id"
                    },
                    "headingDegrees": 1000000,
                    "latitude": 1.1,
                    "longitude": 1.1
                  },
                  "maxAccelerationGForce": 1.1,
                  "media": [
                    {
                      "auxcamSerial": "auxcamSerial",
                      "cameraRole": "leftMirrorMount",
                      "input": "dashcamRoadFacing",
                      "url": "url"
                    },
                    {
                      "auxcamSerial": "auxcamSerial",
                      "cameraRole": "leftMirrorMount",
                      "input": "dashcamRoadFacing",
                      "url": "url"
                    }
                  ],
                  "speedingMetadata": {
                    "maxSpeedKilometersPerHour": 1000000,
                    "postedSpeedLimitKilometersPerHour": 1000000
                  },
                  "startMs": "startMs",
                  "tripEndTime": "tripEndTime",
                  "tripStartTime": "tripStartTime",
                  "updatedAtTime": "updatedAtTime",
                  "updatedByUserId": "updatedByUserId"
                }
              ],
              "pagination": {
                "endCursor": "endCursor",
                "hasNextPage": true
              }
            }
            """;

        Server
            .Given(WireMock.RequestBuilders.Request.Create().WithPath("/safety-events").UsingGet())
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Safety.GetSafetyEventsV2Async(new GetSafetyEventsV2Request());
        JsonAssert.AreEqual(response, mockResponse);
    }
}
