using NUnit.Framework;
using Samsara.Net.Alerts;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.Alerts;

[TestFixture]
public class PatchConfigurationsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "id": "e1c5dffc-c7b7-47b0-a778-6a65de638abf"
            }
            """;

        const string mockResponse = """
            {
              "data": {
                "actions": [
                  {
                    "actionParams": {
                      "driverAppNotification": {
                        "inAppNotificationOptions": {
                          "canDictateAlertTitle": false,
                          "canPlayAlertSound": false,
                          "customText": "Custom text",
                          "isEnabled": true
                        },
                        "pushNotificationOptions": {
                          "isEnabled": true
                        }
                      },
                      "recipients": [
                        {
                          "contactId": "1234",
                          "notificationTypes": [
                            "sms",
                            "email",
                            "email"
                          ],
                          "roleId": "67004a16-be3c-4ef6-a51b-1c45a2c27a92",
                          "type": "user",
                          "userId": "1234"
                        }
                      ],
                      "webhooks": {
                        "webhookIds": [
                          "123",
                          "123",
                          "123",
                          "123"
                        ]
                      }
                    },
                    "actionTypeId": 1
                  }
                ],
                "createdAtTime": "2019-06-13T19:08:25Z",
                "externalIds": {
                  "key": "value"
                },
                "id": "e1c5dffc-c7b7-47b0-a778-6a65de638abf",
                "isEnabled": true,
                "lastModifiedAtTime": "2019-06-13T19:08:25Z",
                "name": "My Harsh Event Alert",
                "operationalSettings": {
                  "timeRangeType": "activeBetween",
                  "timeRanges": [
                    {
                      "daysOfWeek": [
                        "SATURDAY",
                        "WEDNESDAY",
                        "SUNDAY",
                        "FRIDAY"
                      ],
                      "endTime": "20:00",
                      "startTime": "11:00",
                      "timezone": "America/Los_Angeles"
                    }
                  ]
                },
                "scope": {
                  "all": true,
                  "assets": [
                    {
                      "assetId": "12443",
                      "assetType": "uncategorized"
                    }
                  ],
                  "drivers": [
                    {
                      "driverId": "12434"
                    }
                  ],
                  "tags": [
                    {
                      "id": "3914",
                      "name": "East Coast",
                      "parentTagId": "4815"
                    }
                  ],
                  "widgets": [
                    {
                      "widgetId": "12434"
                    }
                  ]
                },
                "triggers": [
                  {
                    "triggerParams": {
                      "ambientTemperature": {
                        "cargoIsFull": true,
                        "doorsAreClosed": true,
                        "minDurationMilliseconds": 600000,
                        "operation": "GREATER",
                        "temperatureCelcius": 60
                      },
                      "cellSignalLoss": {
                        "minDurationMilliseconds": 600000
                      },
                      "defLevel": {
                        "defLevelPercent": 100,
                        "minDurationMilliseconds": 600000,
                        "operation": "GREATER"
                      },
                      "deviceMovement": {
                        "minDurationMilliseconds": 600000
                      },
                      "dvirSubmittedDevice": {
                        "dvirMinDurationMilliseconds": 600000,
                        "dvirSubmissionTypes": [
                          "SAFE_WITH_DEFECTS",
                          "UNSAFE",
                          "SAFE_NO_DEFECTS",
                          "SAFE_NO_DEFECTS"
                        ]
                      },
                      "engineIdle": {
                        "minDurationMilliseconds": 600000
                      },
                      "engineOff": {
                        "minDurationMilliseconds": 600000
                      },
                      "engineOn": {
                        "minDurationMilliseconds": 600000
                      },
                      "fuelLevel": {
                        "fuelLevelPercent": 20,
                        "minDurationMilliseconds": 600000,
                        "operation": "LESS"
                      },
                      "gatewayDisconnected": {
                        "minDurationMilliseconds": 3600000
                      },
                      "gatewayUnplugged": {
                        "minDurationMilliseconds": 600000
                      },
                      "geofenceEntry": {
                        "location": {
                          "addressIds": [
                            "Placeat tempore soluta.",
                            "Nostrum non omnis non esse voluptas.",
                            "Minus nobis."
                          ],
                          "addressTypes": [
                            "workforceSite",
                            "agricultureSource",
                            "shortHaul",
                            "agricultureSource"
                          ],
                          "circle": {
                            "latitude": 37.7749,
                            "longitude": 137.7749,
                            "name": "My Geofence Cirlce",
                            "radiusMeters": 23
                          },
                          "polygon": {
                            "name": "My Geofence Polygon",
                            "vertices": [
                              {
                                "latitude": 37.7749,
                                "longitude": 137.7749
                              }
                            ]
                          },
                          "tagIds": [
                            "4815",
                            "4815",
                            "4815",
                            "4815"
                          ]
                        }
                      },
                      "geofenceExit": {
                        "location": {
                          "addressIds": [
                            "Placeat tempore soluta.",
                            "Nostrum non omnis non esse voluptas.",
                            "Minus nobis."
                          ],
                          "addressTypes": [
                            "workforceSite",
                            "agricultureSource",
                            "shortHaul",
                            "agricultureSource"
                          ],
                          "circle": {
                            "latitude": 37.7749,
                            "longitude": 137.7749,
                            "name": "My Geofence Cirlce",
                            "radiusMeters": 23
                          },
                          "polygon": {
                            "name": "My Geofence Polygon",
                            "vertices": [
                              {
                                "latitude": 37.7749,
                                "longitude": 137.7749
                              }
                            ]
                          },
                          "tagIds": [
                            "4815",
                            "4815",
                            "4815",
                            "4815"
                          ]
                        }
                      },
                      "gpsSignalLoss": {
                        "minDurationMilliseconds": 600000
                      },
                      "hosViolation": {
                        "maxUntilViolationMilliseconds": 600000,
                        "violation": "CaliforniaMealbreakMissed"
                      },
                      "insideGeofence": {
                        "location": {
                          "addressIds": [
                            "Placeat tempore soluta.",
                            "Nostrum non omnis non esse voluptas.",
                            "Minus nobis."
                          ],
                          "addressTypes": [
                            "workforceSite",
                            "agricultureSource",
                            "shortHaul",
                            "agricultureSource"
                          ],
                          "circle": {
                            "latitude": 37.7749,
                            "longitude": 137.7749,
                            "name": "My Geofence Cirlce",
                            "radiusMeters": 23
                          },
                          "polygon": {
                            "name": "My Geofence Polygon",
                            "vertices": [
                              {
                                "latitude": 37.7749,
                                "longitude": 137.7749
                              }
                            ]
                          },
                          "tagIds": [
                            "4815",
                            "4815",
                            "4815",
                            "4815"
                          ]
                        },
                        "minDurationMilliseconds": 600000
                      },
                      "outOfRoute": {
                        "maxOffRouteMeters": 100,
                        "minDurationMilliseconds": 600000
                      },
                      "outsideGeofence": {
                        "location": {
                          "addressIds": [
                            "Placeat tempore soluta.",
                            "Nostrum non omnis non esse voluptas.",
                            "Minus nobis."
                          ],
                          "addressTypes": [
                            "workforceSite",
                            "agricultureSource",
                            "shortHaul",
                            "agricultureSource"
                          ],
                          "circle": {
                            "latitude": 37.7749,
                            "longitude": 137.7749,
                            "name": "My Geofence Cirlce",
                            "radiusMeters": 23
                          },
                          "polygon": {
                            "name": "My Geofence Polygon",
                            "vertices": [
                              {
                                "latitude": 37.7749,
                                "longitude": 137.7749
                              }
                            ]
                          },
                          "tagIds": [
                            "4815",
                            "4815",
                            "4815",
                            "4815"
                          ]
                        },
                        "minDurationMilliseconds": 600000
                      },
                      "panicButton": {
                        "isFilteringOutPowerLoss": true
                      },
                      "reading": {
                        "continuousThreshold": {
                          "operation": "GREATER",
                          "threshold": 20,
                          "upperThreshold": 30
                        },
                        "entityType": "Asset",
                        "enumThreshold": {
                          "number": 2,
                          "symbol": "HIGH"
                        },
                        "id": "engineTemperature",
                        "minDurationMilliseconds": 600000
                      },
                      "routeStopEstimatedArrival": {
                        "alertBeforeArrivalMilliseconds": 300000,
                        "hasLiveShareLink": true,
                        "isAlertOnRouteStopOnly": true,
                        "location": {
                          "addressIds": [
                            "Placeat tempore soluta.",
                            "Nostrum non omnis non esse voluptas.",
                            "Minus nobis."
                          ],
                          "addressTypes": [
                            "workforceSite",
                            "agricultureSource",
                            "shortHaul",
                            "agricultureSource"
                          ],
                          "circle": {
                            "latitude": 37.7749,
                            "longitude": 137.7749,
                            "name": "My Geofence Cirlce",
                            "radiusMeters": 23
                          },
                          "polygon": {
                            "name": "My Geofence Polygon",
                            "vertices": [
                              {
                                "latitude": 37.7749,
                                "longitude": 137.7749
                              }
                            ]
                          },
                          "tagIds": [
                            "4815",
                            "4815",
                            "4815",
                            "4815"
                          ]
                        }
                      },
                      "safetyBehavior": {
                        "behaviorCount": {
                          "comparison": "EQUAL_TO",
                          "numBehaviors": 10,
                          "numDays": 30
                        },
                        "behaviors": [
                          "NearPedestrianCollision",
                          "VehicleInBlindSpotWarning"
                        ],
                        "drivers": {
                          "driverIds": [
                            "12434",
                            "12434",
                            "12434",
                            "12434"
                          ],
                          "tagIds": [
                            "12434",
                            "12434",
                            "12434"
                          ]
                        },
                        "safetyScore": {
                          "comparison": "EQUAL_TO",
                          "score": 60
                        },
                        "severities": [
                          "high",
                          "medium",
                          "high"
                        ],
                        "statuses": [
                          "NEEDS_RECOGNITION",
                          "NEEDS_REVIEW",
                          "NEEDS_COACHING"
                        ]
                      },
                      "scheduledMaintenance": {
                        "dueInDays": 10,
                        "scheduleId": "123"
                      },
                      "scheduledMaintenanceByEngineHours": {
                        "dueInHours": 5000,
                        "scheduleId": "123"
                      },
                      "scheduledMaintenanceOdometer": {
                        "dueInMeters": 5000,
                        "scheduleId": "123"
                      },
                      "speed": {
                        "minDurationMilliseconds": 600000,
                        "operation": "GREATER",
                        "speedKilometersPerHour": 120
                      },
                      "suddenFuelLevelDrop": {
                        "minFuelLevelChangeInPercents": 6
                      },
                      "suddenFuelLevelRise": {
                        "minFuelLevelChangeInPercents": 6
                      },
                      "tireFaultCode": {
                        "hasCautionaryTireFaultCodes": true,
                        "hasCriticalTireFaultCodes": true,
                        "manufacturer": "MANUFACTURER_BENDIX",
                        "specificTireFaultCodes": [
                          "TIRE_ALERT_ACROSS_AXLE_FAULT",
                          "TIRE_ALERT_ACROSS_AXLE_FAULT"
                        ]
                      },
                      "trainingAssignmentNearDueDate": {
                        "conditionUnits": "DAYS",
                        "conditionValue": 1,
                        "timezone": "America/Los_Angeles"
                      },
                      "unassignedDriving": {
                        "minDurationMilliseconds": 600000
                      },
                      "vehicleBatteryVoltage": {
                        "batteryVolts": 100,
                        "minDurationMilliseconds": 600000,
                        "operation": "GREATER"
                      },
                      "vehicleFaultCode": {
                        "hasAnyAmberWarningLampCodes": true,
                        "hasAnyFaultCodes": true,
                        "hasAnyMalfunctionIndicatorLampCodes": true,
                        "hasAnyProtectionLampCodes": true,
                        "hasAnyRedStopLampCodes": true,
                        "hasAnyTrailerAbsLampCodes": true,
                        "minDurationMilliseconds": 600000,
                        "specificFaultCodes": [
                          {
                            "faultCode": "1067",
                            "type": "INVALID_FAULT_CODE_TYPE"
                          }
                        ]
                      }
                    },
                    "triggerTypeId": 1000
                  }
                ]
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/alerts/configurations")
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

        var response = await Client.Alerts.PatchConfigurationsAsync(
            new AlertsPatchConfigurationsRequestBody { Id = "e1c5dffc-c7b7-47b0-a778-6a65de638abf" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
