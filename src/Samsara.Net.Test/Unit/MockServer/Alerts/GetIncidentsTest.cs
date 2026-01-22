using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.Alerts;
using Samsara.Net.Core;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.Alerts;

[TestFixture]
public class GetIncidentsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "conditions": [
                    {
                      "description": "description",
                      "details": {
                        "ambientTemperature": {
                          "sensor": {
                            "id": "id"
                          }
                        },
                        "cameraConnectorDisconected": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "cameraStreamIssue": {
                          "cameraDevice": {
                            "id": "id"
                          }
                        },
                        "cellSignalLoss": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "cloudBackupUploadIssue": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "dashcamDisconnected": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "dataInputValue": {
                          "machineInput": {
                            "id": "id"
                          }
                        },
                        "deviceMovement": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "deviceMovementStopped": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "doorOpen": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "driverAppSignIn": {
                          "driver": {
                            "id": "id"
                          },
                          "pinnedVehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "driverAppSignOut": {
                          "driver": {
                            "id": "id"
                          }
                        },
                        "driverDocumentSubmitted": {},
                        "driverMessageReceived": {
                          "driver": {
                            "id": "id"
                          }
                        },
                        "driverMessageSent": {
                          "driver": {
                            "id": "id"
                          }
                        },
                        "driverRecorded": {
                          "driver": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "dvirSubmittedDevice": {
                          "driver": {
                            "id": "id"
                          },
                          "vehicle": {}
                        },
                        "engineIdle": {
                          "driver": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "engineOff": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "engineOn": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "formSubmitted": {
                          "form": {
                            "assignedAtTime": "2024-01-15T09:30:00.000Z",
                            "createdAtTime": "2024-01-15T09:30:00.000Z",
                            "dueAtTime": "2024-01-15T09:30:00.000Z",
                            "externalIds": {},
                            "fields": [],
                            "formTemplate": {
                              "id": "id",
                              "revisionId": "revisionId"
                            },
                            "id": "id",
                            "isRequired": true,
                            "routeId": "routeId",
                            "routeStopId": "routeStopId",
                            "status": "notStarted",
                            "submittedAtTime": "2024-01-15T09:30:00.000Z",
                            "submittedBy": {
                              "id": "id",
                              "type": "driver"
                            },
                            "title": "title",
                            "updatedAtTime": "2024-01-15T09:30:00.000Z"
                          }
                        },
                        "formUpdated": {
                          "form": {
                            "assignedAtTime": "2024-01-15T09:30:00.000Z",
                            "createdAtTime": "2024-01-15T09:30:00.000Z",
                            "dueAtTime": "2024-01-15T09:30:00.000Z",
                            "externalIds": {},
                            "fields": [],
                            "formTemplate": {
                              "id": "id",
                              "revisionId": "revisionId"
                            },
                            "id": "id",
                            "isRequired": true,
                            "routeId": "routeId",
                            "routeStopId": "routeStopId",
                            "status": "notStarted",
                            "submittedAtTime": "2024-01-15T09:30:00.000Z",
                            "submittedBy": {
                              "id": "id",
                              "type": "driver"
                            },
                            "title": "title",
                            "updatedAtTime": "2024-01-15T09:30:00.000Z"
                          }
                        },
                        "fuelLevelPercentage": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "gatewayDisconnected": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "gatewayUnplugged": {
                          "model": "AG15",
                          "serial": "serial",
                          "vehicle": {}
                        },
                        "geofenceEntry": {
                          "address": {
                            "formattedAddress": "formattedAddress",
                            "id": "id",
                            "name": "name"
                          },
                          "fuelVolume": {
                            "unit": "GALLONS",
                            "value": 1.1
                          },
                          "vehicle": {}
                        },
                        "geofenceExit": {
                          "address": {
                            "formattedAddress": "formattedAddress",
                            "id": "id",
                            "name": "name"
                          },
                          "fuelVolume": {
                            "unit": "GALLONS",
                            "value": 1.1
                          },
                          "vehicle": {}
                        },
                        "gpsSignalLoss": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "harshEvent": {
                          "driver": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "hosViolation": {
                          "driver": {
                            "id": "id"
                          }
                        },
                        "inactivity": {
                          "cameraStream": {
                            "id": "id"
                          }
                        },
                        "insideGeofence": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "issueCreated": {
                          "issue": {
                            "createdAtTime": "2024-01-15T09:30:00.000Z",
                            "description": "description",
                            "dueDate": "2024-01-15T09:30:00.000Z",
                            "externalIds": {},
                            "id": "id",
                            "issueSource": {
                              "type": "form"
                            },
                            "mediaList": [],
                            "priority": "low",
                            "status": "open",
                            "submittedAtTime": "2024-01-15T09:30:00.000Z",
                            "submittedBy": {
                              "id": "id",
                              "type": "driver"
                            },
                            "title": "title",
                            "updatedAtTime": "2024-01-15T09:30:00.000Z"
                          }
                        },
                        "jammingDetected": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "motionDetected": {
                          "cameraStream": {
                            "id": "id"
                          }
                        },
                        "outOfRoute": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "outsideGeofence": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "panicButton": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "personDetected": {
                          "cameraStream": {
                            "id": "id"
                          }
                        },
                        "reading": {
                          "asset": {
                            "id": "id",
                            "serial": "serial",
                            "type": "uncategorized"
                          },
                          "continuousThreshold": {
                            "operation": "GREATER",
                            "threshold": 1000000
                          },
                          "enumThreshold": {},
                          "id": "id"
                        },
                        "reeferTemperature": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "routeStopArrival": {
                          "driver": {
                            "id": "id"
                          },
                          "operation": "stop arrived",
                          "route": {
                            "actualRouteEndTime": "2024-01-15T09:30:00.000Z",
                            "actualRouteStartTime": "2024-01-15T09:30:00.000Z",
                            "externalIds": {},
                            "id": "id",
                            "name": "name",
                            "notes": "notes",
                            "scheduledRouteEndTime": "2024-01-15T09:30:00.000Z",
                            "scheduledRouteStartTime": "2024-01-15T09:30:00.000Z",
                            "settings": {},
                            "stops": []
                          },
                          "routeStopDetails": {
                            "actualArrivalTime": "2024-01-15T09:30:00.000Z",
                            "actualDepartureTime": "2024-01-15T09:30:00.000Z",
                            "enRouteTime": "2024-01-15T09:30:00.000Z",
                            "eta": "2024-01-15T09:30:00.000Z",
                            "externalIds": {},
                            "id": "id",
                            "liveSharingUrl": "liveSharingUrl",
                            "skippedTime": "2024-01-15T09:30:00.000Z",
                            "state": "unassigned"
                          },
                          "time": "2024-01-15T09:30:00.000Z",
                          "type": "route tracking",
                          "vehicle": {}
                        },
                        "routeStopDeparture": {
                          "driver": {
                            "id": "id"
                          },
                          "operation": "stop arrived",
                          "route": {
                            "actualRouteEndTime": "2024-01-15T09:30:00.000Z",
                            "actualRouteStartTime": "2024-01-15T09:30:00.000Z",
                            "externalIds": {},
                            "id": "id",
                            "name": "name",
                            "notes": "notes",
                            "scheduledRouteEndTime": "2024-01-15T09:30:00.000Z",
                            "scheduledRouteStartTime": "2024-01-15T09:30:00.000Z",
                            "settings": {},
                            "stops": []
                          },
                          "routeStopDetails": {
                            "actualArrivalTime": "2024-01-15T09:30:00.000Z",
                            "actualDepartureTime": "2024-01-15T09:30:00.000Z",
                            "enRouteTime": "2024-01-15T09:30:00.000Z",
                            "eta": "2024-01-15T09:30:00.000Z",
                            "externalIds": {},
                            "id": "id",
                            "liveSharingUrl": "liveSharingUrl",
                            "skippedTime": "2024-01-15T09:30:00.000Z",
                            "state": "unassigned"
                          },
                          "time": "2024-01-15T09:30:00.000Z",
                          "type": "route tracking",
                          "vehicle": {}
                        },
                        "routeStopETA": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "scheduledMaintenance": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "scheduledMaintenanceByEngineHours": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "scheduledMaintenanceOdometer": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "severeSpeeding": {
                          "data": {
                            "startTime": "startTime",
                            "tripStartTime": "tripStartTime",
                            "vehicle": {}
                          }
                        },
                        "siteGatewayDisconnected": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "speed": {
                          "currentSpeedKilometersPerHour": 1,
                          "driver": {
                            "id": "id"
                          },
                          "minDurationMilliseconds": 1000000,
                          "operation": "GREATER",
                          "thresholdSpeedKilometersPerHour": 1,
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "suddenFuelLevelDrop": {
                          "changeEndTime": "2024-01-15T09:30:00.000Z",
                          "changeStartTime": "2024-01-15T09:30:00.000Z",
                          "driver": {
                            "id": "id"
                          },
                          "fuelLevelAfterMillipercent": 1,
                          "fuelLevelBeforeMillipercent": 1,
                          "location": {},
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "suddenFuelLevelRise": {
                          "changeEndTime": "2024-01-15T09:30:00.000Z",
                          "changeStartTime": "2024-01-15T09:30:00.000Z",
                          "driver": {
                            "id": "id"
                          },
                          "fuelLevelAfterMillipercent": 1,
                          "fuelLevelBeforeMillipercent": 1,
                          "location": {},
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "tamperingDetected": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "tireFaults": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "unassignedDriving": {
                          "driver": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "vehicleBatteryVoltage": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "vehicleDefLevelPercentage": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "vehicleDetected": {
                          "cameraStream": {
                            "id": "id"
                          }
                        },
                        "vehicleFaults": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "workerSafetySos": {
                          "driver": {
                            "id": "id"
                          },
                          "location": {},
                          "sourceType": "appSos",
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          },
                          "workerSafetyIncidentUrl": "workerSafetyIncidentUrl"
                        }
                      },
                      "triggerId": 1000000
                    },
                    {
                      "description": "description",
                      "details": {
                        "ambientTemperature": {
                          "sensor": {
                            "id": "id"
                          }
                        },
                        "cameraConnectorDisconected": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "cameraStreamIssue": {
                          "cameraDevice": {
                            "id": "id"
                          }
                        },
                        "cellSignalLoss": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "cloudBackupUploadIssue": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "dashcamDisconnected": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "dataInputValue": {
                          "machineInput": {
                            "id": "id"
                          }
                        },
                        "deviceMovement": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "deviceMovementStopped": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "doorOpen": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "driverAppSignIn": {
                          "driver": {
                            "id": "id"
                          },
                          "pinnedVehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "driverAppSignOut": {
                          "driver": {
                            "id": "id"
                          }
                        },
                        "driverDocumentSubmitted": {},
                        "driverMessageReceived": {
                          "driver": {
                            "id": "id"
                          }
                        },
                        "driverMessageSent": {
                          "driver": {
                            "id": "id"
                          }
                        },
                        "driverRecorded": {
                          "driver": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "dvirSubmittedDevice": {
                          "driver": {
                            "id": "id"
                          },
                          "vehicle": {}
                        },
                        "engineIdle": {
                          "driver": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "engineOff": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "engineOn": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "formSubmitted": {
                          "form": {
                            "assignedAtTime": "2024-01-15T09:30:00.000Z",
                            "createdAtTime": "2024-01-15T09:30:00.000Z",
                            "dueAtTime": "2024-01-15T09:30:00.000Z",
                            "externalIds": {},
                            "fields": [],
                            "formTemplate": {
                              "id": "id",
                              "revisionId": "revisionId"
                            },
                            "id": "id",
                            "isRequired": true,
                            "routeId": "routeId",
                            "routeStopId": "routeStopId",
                            "status": "notStarted",
                            "submittedAtTime": "2024-01-15T09:30:00.000Z",
                            "submittedBy": {
                              "id": "id",
                              "type": "driver"
                            },
                            "title": "title",
                            "updatedAtTime": "2024-01-15T09:30:00.000Z"
                          }
                        },
                        "formUpdated": {
                          "form": {
                            "assignedAtTime": "2024-01-15T09:30:00.000Z",
                            "createdAtTime": "2024-01-15T09:30:00.000Z",
                            "dueAtTime": "2024-01-15T09:30:00.000Z",
                            "externalIds": {},
                            "fields": [],
                            "formTemplate": {
                              "id": "id",
                              "revisionId": "revisionId"
                            },
                            "id": "id",
                            "isRequired": true,
                            "routeId": "routeId",
                            "routeStopId": "routeStopId",
                            "status": "notStarted",
                            "submittedAtTime": "2024-01-15T09:30:00.000Z",
                            "submittedBy": {
                              "id": "id",
                              "type": "driver"
                            },
                            "title": "title",
                            "updatedAtTime": "2024-01-15T09:30:00.000Z"
                          }
                        },
                        "fuelLevelPercentage": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "gatewayDisconnected": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "gatewayUnplugged": {
                          "model": "AG15",
                          "serial": "serial",
                          "vehicle": {}
                        },
                        "geofenceEntry": {
                          "address": {
                            "formattedAddress": "formattedAddress",
                            "id": "id",
                            "name": "name"
                          },
                          "fuelVolume": {
                            "unit": "GALLONS",
                            "value": 1.1
                          },
                          "vehicle": {}
                        },
                        "geofenceExit": {
                          "address": {
                            "formattedAddress": "formattedAddress",
                            "id": "id",
                            "name": "name"
                          },
                          "fuelVolume": {
                            "unit": "GALLONS",
                            "value": 1.1
                          },
                          "vehicle": {}
                        },
                        "gpsSignalLoss": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "harshEvent": {
                          "driver": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "hosViolation": {
                          "driver": {
                            "id": "id"
                          }
                        },
                        "inactivity": {
                          "cameraStream": {
                            "id": "id"
                          }
                        },
                        "insideGeofence": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "issueCreated": {
                          "issue": {
                            "createdAtTime": "2024-01-15T09:30:00.000Z",
                            "description": "description",
                            "dueDate": "2024-01-15T09:30:00.000Z",
                            "externalIds": {},
                            "id": "id",
                            "issueSource": {
                              "type": "form"
                            },
                            "mediaList": [],
                            "priority": "low",
                            "status": "open",
                            "submittedAtTime": "2024-01-15T09:30:00.000Z",
                            "submittedBy": {
                              "id": "id",
                              "type": "driver"
                            },
                            "title": "title",
                            "updatedAtTime": "2024-01-15T09:30:00.000Z"
                          }
                        },
                        "jammingDetected": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "motionDetected": {
                          "cameraStream": {
                            "id": "id"
                          }
                        },
                        "outOfRoute": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "outsideGeofence": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "panicButton": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "personDetected": {
                          "cameraStream": {
                            "id": "id"
                          }
                        },
                        "reading": {
                          "asset": {
                            "id": "id",
                            "serial": "serial",
                            "type": "uncategorized"
                          },
                          "continuousThreshold": {
                            "operation": "GREATER",
                            "threshold": 1000000
                          },
                          "enumThreshold": {},
                          "id": "id"
                        },
                        "reeferTemperature": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "routeStopArrival": {
                          "driver": {
                            "id": "id"
                          },
                          "operation": "stop arrived",
                          "route": {
                            "actualRouteEndTime": "2024-01-15T09:30:00.000Z",
                            "actualRouteStartTime": "2024-01-15T09:30:00.000Z",
                            "externalIds": {},
                            "id": "id",
                            "name": "name",
                            "notes": "notes",
                            "scheduledRouteEndTime": "2024-01-15T09:30:00.000Z",
                            "scheduledRouteStartTime": "2024-01-15T09:30:00.000Z",
                            "settings": {},
                            "stops": []
                          },
                          "routeStopDetails": {
                            "actualArrivalTime": "2024-01-15T09:30:00.000Z",
                            "actualDepartureTime": "2024-01-15T09:30:00.000Z",
                            "enRouteTime": "2024-01-15T09:30:00.000Z",
                            "eta": "2024-01-15T09:30:00.000Z",
                            "externalIds": {},
                            "id": "id",
                            "liveSharingUrl": "liveSharingUrl",
                            "skippedTime": "2024-01-15T09:30:00.000Z",
                            "state": "unassigned"
                          },
                          "time": "2024-01-15T09:30:00.000Z",
                          "type": "route tracking",
                          "vehicle": {}
                        },
                        "routeStopDeparture": {
                          "driver": {
                            "id": "id"
                          },
                          "operation": "stop arrived",
                          "route": {
                            "actualRouteEndTime": "2024-01-15T09:30:00.000Z",
                            "actualRouteStartTime": "2024-01-15T09:30:00.000Z",
                            "externalIds": {},
                            "id": "id",
                            "name": "name",
                            "notes": "notes",
                            "scheduledRouteEndTime": "2024-01-15T09:30:00.000Z",
                            "scheduledRouteStartTime": "2024-01-15T09:30:00.000Z",
                            "settings": {},
                            "stops": []
                          },
                          "routeStopDetails": {
                            "actualArrivalTime": "2024-01-15T09:30:00.000Z",
                            "actualDepartureTime": "2024-01-15T09:30:00.000Z",
                            "enRouteTime": "2024-01-15T09:30:00.000Z",
                            "eta": "2024-01-15T09:30:00.000Z",
                            "externalIds": {},
                            "id": "id",
                            "liveSharingUrl": "liveSharingUrl",
                            "skippedTime": "2024-01-15T09:30:00.000Z",
                            "state": "unassigned"
                          },
                          "time": "2024-01-15T09:30:00.000Z",
                          "type": "route tracking",
                          "vehicle": {}
                        },
                        "routeStopETA": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "scheduledMaintenance": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "scheduledMaintenanceByEngineHours": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "scheduledMaintenanceOdometer": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "severeSpeeding": {
                          "data": {
                            "startTime": "startTime",
                            "tripStartTime": "tripStartTime",
                            "vehicle": {}
                          }
                        },
                        "siteGatewayDisconnected": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "speed": {
                          "currentSpeedKilometersPerHour": 1,
                          "driver": {
                            "id": "id"
                          },
                          "minDurationMilliseconds": 1000000,
                          "operation": "GREATER",
                          "thresholdSpeedKilometersPerHour": 1,
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "suddenFuelLevelDrop": {
                          "changeEndTime": "2024-01-15T09:30:00.000Z",
                          "changeStartTime": "2024-01-15T09:30:00.000Z",
                          "driver": {
                            "id": "id"
                          },
                          "fuelLevelAfterMillipercent": 1,
                          "fuelLevelBeforeMillipercent": 1,
                          "location": {},
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "suddenFuelLevelRise": {
                          "changeEndTime": "2024-01-15T09:30:00.000Z",
                          "changeStartTime": "2024-01-15T09:30:00.000Z",
                          "driver": {
                            "id": "id"
                          },
                          "fuelLevelAfterMillipercent": 1,
                          "fuelLevelBeforeMillipercent": 1,
                          "location": {},
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "tamperingDetected": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "tireFaults": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "unassignedDriving": {
                          "driver": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "vehicleBatteryVoltage": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "vehicleDefLevelPercentage": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "vehicleDetected": {
                          "cameraStream": {
                            "id": "id"
                          }
                        },
                        "vehicleFaults": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "workerSafetySos": {
                          "driver": {
                            "id": "id"
                          },
                          "location": {},
                          "sourceType": "appSos",
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          },
                          "workerSafetyIncidentUrl": "workerSafetyIncidentUrl"
                        }
                      },
                      "triggerId": 1000000
                    }
                  ],
                  "configurationId": "configurationId",
                  "happenedAtTime": "happenedAtTime",
                  "incidentUrl": "incidentUrl",
                  "isResolved": true,
                  "resolvedAtTime": "resolvedAtTime",
                  "updatedAtTime": "updatedAtTime"
                },
                {
                  "conditions": [
                    {
                      "description": "description",
                      "details": {
                        "ambientTemperature": {
                          "sensor": {
                            "id": "id"
                          }
                        },
                        "cameraConnectorDisconected": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "cameraStreamIssue": {
                          "cameraDevice": {
                            "id": "id"
                          }
                        },
                        "cellSignalLoss": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "cloudBackupUploadIssue": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "dashcamDisconnected": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "dataInputValue": {
                          "machineInput": {
                            "id": "id"
                          }
                        },
                        "deviceMovement": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "deviceMovementStopped": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "doorOpen": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "driverAppSignIn": {
                          "driver": {
                            "id": "id"
                          },
                          "pinnedVehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "driverAppSignOut": {
                          "driver": {
                            "id": "id"
                          }
                        },
                        "driverDocumentSubmitted": {},
                        "driverMessageReceived": {
                          "driver": {
                            "id": "id"
                          }
                        },
                        "driverMessageSent": {
                          "driver": {
                            "id": "id"
                          }
                        },
                        "driverRecorded": {
                          "driver": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "dvirSubmittedDevice": {
                          "driver": {
                            "id": "id"
                          },
                          "vehicle": {}
                        },
                        "engineIdle": {
                          "driver": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "engineOff": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "engineOn": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "formSubmitted": {
                          "form": {
                            "assignedAtTime": "2024-01-15T09:30:00.000Z",
                            "createdAtTime": "2024-01-15T09:30:00.000Z",
                            "dueAtTime": "2024-01-15T09:30:00.000Z",
                            "externalIds": {},
                            "fields": [],
                            "formTemplate": {
                              "id": "id",
                              "revisionId": "revisionId"
                            },
                            "id": "id",
                            "isRequired": true,
                            "routeId": "routeId",
                            "routeStopId": "routeStopId",
                            "status": "notStarted",
                            "submittedAtTime": "2024-01-15T09:30:00.000Z",
                            "submittedBy": {
                              "id": "id",
                              "type": "driver"
                            },
                            "title": "title",
                            "updatedAtTime": "2024-01-15T09:30:00.000Z"
                          }
                        },
                        "formUpdated": {
                          "form": {
                            "assignedAtTime": "2024-01-15T09:30:00.000Z",
                            "createdAtTime": "2024-01-15T09:30:00.000Z",
                            "dueAtTime": "2024-01-15T09:30:00.000Z",
                            "externalIds": {},
                            "fields": [],
                            "formTemplate": {
                              "id": "id",
                              "revisionId": "revisionId"
                            },
                            "id": "id",
                            "isRequired": true,
                            "routeId": "routeId",
                            "routeStopId": "routeStopId",
                            "status": "notStarted",
                            "submittedAtTime": "2024-01-15T09:30:00.000Z",
                            "submittedBy": {
                              "id": "id",
                              "type": "driver"
                            },
                            "title": "title",
                            "updatedAtTime": "2024-01-15T09:30:00.000Z"
                          }
                        },
                        "fuelLevelPercentage": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "gatewayDisconnected": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "gatewayUnplugged": {
                          "model": "AG15",
                          "serial": "serial",
                          "vehicle": {}
                        },
                        "geofenceEntry": {
                          "address": {
                            "formattedAddress": "formattedAddress",
                            "id": "id",
                            "name": "name"
                          },
                          "fuelVolume": {
                            "unit": "GALLONS",
                            "value": 1.1
                          },
                          "vehicle": {}
                        },
                        "geofenceExit": {
                          "address": {
                            "formattedAddress": "formattedAddress",
                            "id": "id",
                            "name": "name"
                          },
                          "fuelVolume": {
                            "unit": "GALLONS",
                            "value": 1.1
                          },
                          "vehicle": {}
                        },
                        "gpsSignalLoss": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "harshEvent": {
                          "driver": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "hosViolation": {
                          "driver": {
                            "id": "id"
                          }
                        },
                        "inactivity": {
                          "cameraStream": {
                            "id": "id"
                          }
                        },
                        "insideGeofence": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "issueCreated": {
                          "issue": {
                            "createdAtTime": "2024-01-15T09:30:00.000Z",
                            "description": "description",
                            "dueDate": "2024-01-15T09:30:00.000Z",
                            "externalIds": {},
                            "id": "id",
                            "issueSource": {
                              "type": "form"
                            },
                            "mediaList": [],
                            "priority": "low",
                            "status": "open",
                            "submittedAtTime": "2024-01-15T09:30:00.000Z",
                            "submittedBy": {
                              "id": "id",
                              "type": "driver"
                            },
                            "title": "title",
                            "updatedAtTime": "2024-01-15T09:30:00.000Z"
                          }
                        },
                        "jammingDetected": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "motionDetected": {
                          "cameraStream": {
                            "id": "id"
                          }
                        },
                        "outOfRoute": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "outsideGeofence": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "panicButton": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "personDetected": {
                          "cameraStream": {
                            "id": "id"
                          }
                        },
                        "reading": {
                          "asset": {
                            "id": "id",
                            "serial": "serial",
                            "type": "uncategorized"
                          },
                          "continuousThreshold": {
                            "operation": "GREATER",
                            "threshold": 1000000
                          },
                          "enumThreshold": {},
                          "id": "id"
                        },
                        "reeferTemperature": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "routeStopArrival": {
                          "driver": {
                            "id": "id"
                          },
                          "operation": "stop arrived",
                          "route": {
                            "actualRouteEndTime": "2024-01-15T09:30:00.000Z",
                            "actualRouteStartTime": "2024-01-15T09:30:00.000Z",
                            "externalIds": {},
                            "id": "id",
                            "name": "name",
                            "notes": "notes",
                            "scheduledRouteEndTime": "2024-01-15T09:30:00.000Z",
                            "scheduledRouteStartTime": "2024-01-15T09:30:00.000Z",
                            "settings": {},
                            "stops": []
                          },
                          "routeStopDetails": {
                            "actualArrivalTime": "2024-01-15T09:30:00.000Z",
                            "actualDepartureTime": "2024-01-15T09:30:00.000Z",
                            "enRouteTime": "2024-01-15T09:30:00.000Z",
                            "eta": "2024-01-15T09:30:00.000Z",
                            "externalIds": {},
                            "id": "id",
                            "liveSharingUrl": "liveSharingUrl",
                            "skippedTime": "2024-01-15T09:30:00.000Z",
                            "state": "unassigned"
                          },
                          "time": "2024-01-15T09:30:00.000Z",
                          "type": "route tracking",
                          "vehicle": {}
                        },
                        "routeStopDeparture": {
                          "driver": {
                            "id": "id"
                          },
                          "operation": "stop arrived",
                          "route": {
                            "actualRouteEndTime": "2024-01-15T09:30:00.000Z",
                            "actualRouteStartTime": "2024-01-15T09:30:00.000Z",
                            "externalIds": {},
                            "id": "id",
                            "name": "name",
                            "notes": "notes",
                            "scheduledRouteEndTime": "2024-01-15T09:30:00.000Z",
                            "scheduledRouteStartTime": "2024-01-15T09:30:00.000Z",
                            "settings": {},
                            "stops": []
                          },
                          "routeStopDetails": {
                            "actualArrivalTime": "2024-01-15T09:30:00.000Z",
                            "actualDepartureTime": "2024-01-15T09:30:00.000Z",
                            "enRouteTime": "2024-01-15T09:30:00.000Z",
                            "eta": "2024-01-15T09:30:00.000Z",
                            "externalIds": {},
                            "id": "id",
                            "liveSharingUrl": "liveSharingUrl",
                            "skippedTime": "2024-01-15T09:30:00.000Z",
                            "state": "unassigned"
                          },
                          "time": "2024-01-15T09:30:00.000Z",
                          "type": "route tracking",
                          "vehicle": {}
                        },
                        "routeStopETA": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "scheduledMaintenance": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "scheduledMaintenanceByEngineHours": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "scheduledMaintenanceOdometer": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "severeSpeeding": {
                          "data": {
                            "startTime": "startTime",
                            "tripStartTime": "tripStartTime",
                            "vehicle": {}
                          }
                        },
                        "siteGatewayDisconnected": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "speed": {
                          "currentSpeedKilometersPerHour": 1,
                          "driver": {
                            "id": "id"
                          },
                          "minDurationMilliseconds": 1000000,
                          "operation": "GREATER",
                          "thresholdSpeedKilometersPerHour": 1,
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "suddenFuelLevelDrop": {
                          "changeEndTime": "2024-01-15T09:30:00.000Z",
                          "changeStartTime": "2024-01-15T09:30:00.000Z",
                          "driver": {
                            "id": "id"
                          },
                          "fuelLevelAfterMillipercent": 1,
                          "fuelLevelBeforeMillipercent": 1,
                          "location": {},
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "suddenFuelLevelRise": {
                          "changeEndTime": "2024-01-15T09:30:00.000Z",
                          "changeStartTime": "2024-01-15T09:30:00.000Z",
                          "driver": {
                            "id": "id"
                          },
                          "fuelLevelAfterMillipercent": 1,
                          "fuelLevelBeforeMillipercent": 1,
                          "location": {},
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "tamperingDetected": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "tireFaults": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "unassignedDriving": {
                          "driver": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "vehicleBatteryVoltage": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "vehicleDefLevelPercentage": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "vehicleDetected": {
                          "cameraStream": {
                            "id": "id"
                          }
                        },
                        "vehicleFaults": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "workerSafetySos": {
                          "driver": {
                            "id": "id"
                          },
                          "location": {},
                          "sourceType": "appSos",
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          },
                          "workerSafetyIncidentUrl": "workerSafetyIncidentUrl"
                        }
                      },
                      "triggerId": 1000000
                    },
                    {
                      "description": "description",
                      "details": {
                        "ambientTemperature": {
                          "sensor": {
                            "id": "id"
                          }
                        },
                        "cameraConnectorDisconected": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "cameraStreamIssue": {
                          "cameraDevice": {
                            "id": "id"
                          }
                        },
                        "cellSignalLoss": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "cloudBackupUploadIssue": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "dashcamDisconnected": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "dataInputValue": {
                          "machineInput": {
                            "id": "id"
                          }
                        },
                        "deviceMovement": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "deviceMovementStopped": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "doorOpen": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "driverAppSignIn": {
                          "driver": {
                            "id": "id"
                          },
                          "pinnedVehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "driverAppSignOut": {
                          "driver": {
                            "id": "id"
                          }
                        },
                        "driverDocumentSubmitted": {},
                        "driverMessageReceived": {
                          "driver": {
                            "id": "id"
                          }
                        },
                        "driverMessageSent": {
                          "driver": {
                            "id": "id"
                          }
                        },
                        "driverRecorded": {
                          "driver": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "dvirSubmittedDevice": {
                          "driver": {
                            "id": "id"
                          },
                          "vehicle": {}
                        },
                        "engineIdle": {
                          "driver": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "engineOff": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "engineOn": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "formSubmitted": {
                          "form": {
                            "assignedAtTime": "2024-01-15T09:30:00.000Z",
                            "createdAtTime": "2024-01-15T09:30:00.000Z",
                            "dueAtTime": "2024-01-15T09:30:00.000Z",
                            "externalIds": {},
                            "fields": [],
                            "formTemplate": {
                              "id": "id",
                              "revisionId": "revisionId"
                            },
                            "id": "id",
                            "isRequired": true,
                            "routeId": "routeId",
                            "routeStopId": "routeStopId",
                            "status": "notStarted",
                            "submittedAtTime": "2024-01-15T09:30:00.000Z",
                            "submittedBy": {
                              "id": "id",
                              "type": "driver"
                            },
                            "title": "title",
                            "updatedAtTime": "2024-01-15T09:30:00.000Z"
                          }
                        },
                        "formUpdated": {
                          "form": {
                            "assignedAtTime": "2024-01-15T09:30:00.000Z",
                            "createdAtTime": "2024-01-15T09:30:00.000Z",
                            "dueAtTime": "2024-01-15T09:30:00.000Z",
                            "externalIds": {},
                            "fields": [],
                            "formTemplate": {
                              "id": "id",
                              "revisionId": "revisionId"
                            },
                            "id": "id",
                            "isRequired": true,
                            "routeId": "routeId",
                            "routeStopId": "routeStopId",
                            "status": "notStarted",
                            "submittedAtTime": "2024-01-15T09:30:00.000Z",
                            "submittedBy": {
                              "id": "id",
                              "type": "driver"
                            },
                            "title": "title",
                            "updatedAtTime": "2024-01-15T09:30:00.000Z"
                          }
                        },
                        "fuelLevelPercentage": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "gatewayDisconnected": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "gatewayUnplugged": {
                          "model": "AG15",
                          "serial": "serial",
                          "vehicle": {}
                        },
                        "geofenceEntry": {
                          "address": {
                            "formattedAddress": "formattedAddress",
                            "id": "id",
                            "name": "name"
                          },
                          "fuelVolume": {
                            "unit": "GALLONS",
                            "value": 1.1
                          },
                          "vehicle": {}
                        },
                        "geofenceExit": {
                          "address": {
                            "formattedAddress": "formattedAddress",
                            "id": "id",
                            "name": "name"
                          },
                          "fuelVolume": {
                            "unit": "GALLONS",
                            "value": 1.1
                          },
                          "vehicle": {}
                        },
                        "gpsSignalLoss": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "harshEvent": {
                          "driver": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "hosViolation": {
                          "driver": {
                            "id": "id"
                          }
                        },
                        "inactivity": {
                          "cameraStream": {
                            "id": "id"
                          }
                        },
                        "insideGeofence": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "issueCreated": {
                          "issue": {
                            "createdAtTime": "2024-01-15T09:30:00.000Z",
                            "description": "description",
                            "dueDate": "2024-01-15T09:30:00.000Z",
                            "externalIds": {},
                            "id": "id",
                            "issueSource": {
                              "type": "form"
                            },
                            "mediaList": [],
                            "priority": "low",
                            "status": "open",
                            "submittedAtTime": "2024-01-15T09:30:00.000Z",
                            "submittedBy": {
                              "id": "id",
                              "type": "driver"
                            },
                            "title": "title",
                            "updatedAtTime": "2024-01-15T09:30:00.000Z"
                          }
                        },
                        "jammingDetected": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "motionDetected": {
                          "cameraStream": {
                            "id": "id"
                          }
                        },
                        "outOfRoute": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "outsideGeofence": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "panicButton": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "personDetected": {
                          "cameraStream": {
                            "id": "id"
                          }
                        },
                        "reading": {
                          "asset": {
                            "id": "id",
                            "serial": "serial",
                            "type": "uncategorized"
                          },
                          "continuousThreshold": {
                            "operation": "GREATER",
                            "threshold": 1000000
                          },
                          "enumThreshold": {},
                          "id": "id"
                        },
                        "reeferTemperature": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "routeStopArrival": {
                          "driver": {
                            "id": "id"
                          },
                          "operation": "stop arrived",
                          "route": {
                            "actualRouteEndTime": "2024-01-15T09:30:00.000Z",
                            "actualRouteStartTime": "2024-01-15T09:30:00.000Z",
                            "externalIds": {},
                            "id": "id",
                            "name": "name",
                            "notes": "notes",
                            "scheduledRouteEndTime": "2024-01-15T09:30:00.000Z",
                            "scheduledRouteStartTime": "2024-01-15T09:30:00.000Z",
                            "settings": {},
                            "stops": []
                          },
                          "routeStopDetails": {
                            "actualArrivalTime": "2024-01-15T09:30:00.000Z",
                            "actualDepartureTime": "2024-01-15T09:30:00.000Z",
                            "enRouteTime": "2024-01-15T09:30:00.000Z",
                            "eta": "2024-01-15T09:30:00.000Z",
                            "externalIds": {},
                            "id": "id",
                            "liveSharingUrl": "liveSharingUrl",
                            "skippedTime": "2024-01-15T09:30:00.000Z",
                            "state": "unassigned"
                          },
                          "time": "2024-01-15T09:30:00.000Z",
                          "type": "route tracking",
                          "vehicle": {}
                        },
                        "routeStopDeparture": {
                          "driver": {
                            "id": "id"
                          },
                          "operation": "stop arrived",
                          "route": {
                            "actualRouteEndTime": "2024-01-15T09:30:00.000Z",
                            "actualRouteStartTime": "2024-01-15T09:30:00.000Z",
                            "externalIds": {},
                            "id": "id",
                            "name": "name",
                            "notes": "notes",
                            "scheduledRouteEndTime": "2024-01-15T09:30:00.000Z",
                            "scheduledRouteStartTime": "2024-01-15T09:30:00.000Z",
                            "settings": {},
                            "stops": []
                          },
                          "routeStopDetails": {
                            "actualArrivalTime": "2024-01-15T09:30:00.000Z",
                            "actualDepartureTime": "2024-01-15T09:30:00.000Z",
                            "enRouteTime": "2024-01-15T09:30:00.000Z",
                            "eta": "2024-01-15T09:30:00.000Z",
                            "externalIds": {},
                            "id": "id",
                            "liveSharingUrl": "liveSharingUrl",
                            "skippedTime": "2024-01-15T09:30:00.000Z",
                            "state": "unassigned"
                          },
                          "time": "2024-01-15T09:30:00.000Z",
                          "type": "route tracking",
                          "vehicle": {}
                        },
                        "routeStopETA": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "scheduledMaintenance": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "scheduledMaintenanceByEngineHours": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "scheduledMaintenanceOdometer": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "severeSpeeding": {
                          "data": {
                            "startTime": "startTime",
                            "tripStartTime": "tripStartTime",
                            "vehicle": {}
                          }
                        },
                        "siteGatewayDisconnected": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "speed": {
                          "currentSpeedKilometersPerHour": 1,
                          "driver": {
                            "id": "id"
                          },
                          "minDurationMilliseconds": 1000000,
                          "operation": "GREATER",
                          "thresholdSpeedKilometersPerHour": 1,
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "suddenFuelLevelDrop": {
                          "changeEndTime": "2024-01-15T09:30:00.000Z",
                          "changeStartTime": "2024-01-15T09:30:00.000Z",
                          "driver": {
                            "id": "id"
                          },
                          "fuelLevelAfterMillipercent": 1,
                          "fuelLevelBeforeMillipercent": 1,
                          "location": {},
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "suddenFuelLevelRise": {
                          "changeEndTime": "2024-01-15T09:30:00.000Z",
                          "changeStartTime": "2024-01-15T09:30:00.000Z",
                          "driver": {
                            "id": "id"
                          },
                          "fuelLevelAfterMillipercent": 1,
                          "fuelLevelBeforeMillipercent": 1,
                          "location": {},
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "tamperingDetected": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "tireFaults": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "unassignedDriving": {
                          "driver": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "vehicleBatteryVoltage": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "vehicleDefLevelPercentage": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "vehicleDetected": {
                          "cameraStream": {
                            "id": "id"
                          }
                        },
                        "vehicleFaults": {
                          "driver": {
                            "id": "id"
                          },
                          "trailer": {
                            "id": "id"
                          },
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          }
                        },
                        "workerSafetySos": {
                          "driver": {
                            "id": "id"
                          },
                          "location": {},
                          "sourceType": "appSos",
                          "vehicle": {
                            "id": "id",
                            "serial": "serial"
                          },
                          "workerSafetyIncidentUrl": "workerSafetyIncidentUrl"
                        }
                      },
                      "triggerId": 1000000
                    }
                  ],
                  "configurationId": "configurationId",
                  "happenedAtTime": "happenedAtTime",
                  "incidentUrl": "incidentUrl",
                  "isResolved": true,
                  "resolvedAtTime": "resolvedAtTime",
                  "updatedAtTime": "updatedAtTime"
                }
              ],
              "pagination": {
                "endCursor": "endCursor",
                "hasNextPage": true
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/alerts/incidents/stream")
                    .WithParam("startTime", "startTime")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Alerts.GetIncidentsAsync(
            new GetIncidentsRequest { StartTime = "startTime" }
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<AlertsGetIncidentsResponseBody>(mockResponse))
                .UsingDefaults()
        );
    }
}
