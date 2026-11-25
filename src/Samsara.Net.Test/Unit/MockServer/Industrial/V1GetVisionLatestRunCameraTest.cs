using NUnit.Framework;
using Samsara.Net.Industrial;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.Industrial;

[TestFixture]
public class V1GetVisionLatestRunCameraTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "cameraId": 1234512345123,
              "endedAtMs": 0,
              "inspectionResults": [
                {
                  "captureAtMs": 1553811994730,
                  "result": "PASS",
                  "stepResults": [
                    {
                      "angleCheck": {
                        "angleConfigured": {
                          "high": 150,
                          "low": 90
                        },
                        "angleFound": 60,
                        "endStepName": "Edge 2",
                        "startStepName": "Edge 1"
                      },
                      "barcode": [
                        {
                          "contents": "10855639004823",
                          "matchString": "10855639004823",
                          "type": "EAN8"
                        }
                      ],
                      "booleanLogic": {
                        "operator": "AND",
                        "steps": [
                          {
                            "name": "Expiration Date",
                            "result": "PASS"
                          }
                        ]
                      },
                      "caliper": {
                        "angleRange": {
                          "high": 360,
                          "low": 0
                        },
                        "contrastRange": {
                          "high": 100,
                          "low": 50
                        },
                        "distanceFound": 555.55,
                        "maxDistance": 1000,
                        "minDistance": 500,
                        "sharpnessRange": {
                          "high": 100,
                          "low": 80
                        },
                        "straightnessRange": {
                          "high": 100,
                          "low": 80
                        },
                        "unit": "Millimeters"
                      },
                      "contour": {
                        "angleDegrees": 0,
                        "angleTolerance": 50,
                        "matchPercentage": 46,
                        "matchThreshold": 18
                      },
                      "distance": {
                        "endStepName": "Bottom Right Square",
                        "enforceOffsetAngleRange": true,
                        "maxDistance": 900,
                        "maxOffsetAngle": 90,
                        "minDistance": 1500,
                        "minOffsetAngle": 45,
                        "offsetAngleFound": 50,
                        "startStepName": "Top Left Square",
                        "unit": "Millimeters"
                      },
                      "expirationDate": {
                        "dateOffset": 1,
                        "foundDate": "06/13/2019",
                        "matchDate": "06/13/2019"
                      },
                      "findCopies": {
                        "angleTolerance": 10,
                        "foundCount": 1,
                        "maxCount": 5,
                        "minCount": 1,
                        "threshold": 70
                      },
                      "findEdge": {
                        "angleFound": 90,
                        "angleRange": {
                          "high": 360,
                          "low": 0
                        },
                        "contrastRange": {
                          "high": 100,
                          "low": 50
                        },
                        "filterPolarity": "ANY",
                        "sharpnessPercent": 95,
                        "sharpnessRange": {
                          "high": 100,
                          "low": 80
                        },
                        "straightnessFound": 95,
                        "straightnessRange": {
                          "high": 100,
                          "low": 80
                        }
                      },
                      "findShapes": {
                        "foundCount": 1,
                        "maxCount": 5,
                        "minCount": 1
                      },
                      "fixture": {
                        "coordinates": {
                          "x": 10,
                          "y": 10
                        },
                        "found": true,
                        "rotationDegrees": 90
                      },
                      "labelMatch": {
                        "score": 10,
                        "threshold": 10
                      },
                      "name": "Chicken Caesar Label",
                      "presenceAbsence": {
                        "blueRange": {
                          "high": 150,
                          "low": 90
                        },
                        "checkForAbsence": true,
                        "grayscaleRange": {
                          "high": 100,
                          "low": 20
                        },
                        "greenRange": {
                          "high": 150,
                          "low": 90
                        },
                        "hueRange": {
                          "high": 100,
                          "low": 20
                        },
                        "redRange": {
                          "high": 150,
                          "low": 90
                        },
                        "saturationRange": {
                          "high": 50,
                          "low": 10
                        },
                        "score": 50,
                        "threshold": 50,
                        "valueRange": {
                          "high": 50,
                          "low": 10
                        }
                      },
                      "result": "PASS",
                      "textMatch": {
                        "foundText": "ABCD",
                        "matchString": "ABCD"
                      }
                    }
                  ]
                }
              ],
              "isOngoing": true,
              "program": {
                "id": 1,
                "name": "Barcode verification program"
              },
              "runSummary": {
                "itemsPerMinute": 0.1,
                "noReadCount": 0,
                "rejectCount": 0,
                "successCount": 181
              },
              "startedAtMs": 1553808606097
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/industrial/vision/run/camera/1000000")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Industrial.V1GetVisionLatestRunCameraAsync(
            new V1GetVisionLatestRunCameraRequest { CameraId = 1000000 }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
