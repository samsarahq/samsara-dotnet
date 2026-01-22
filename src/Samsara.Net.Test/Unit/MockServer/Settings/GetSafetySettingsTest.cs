using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.Core;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.Settings;

[TestFixture]
public class GetSafetySettingsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "defaultVehicleType": "off",
                  "distractedDrivingDetectionAlerts": {
                    "isEnabled": true
                  },
                  "followingDistanceDetectionAlerts": {
                    "durationMs": 15000,
                    "hasInCabAudioAlertsEnabled": true,
                    "isEnabled": true,
                    "speedingThresholdMph": 35
                  },
                  "forwardCollisionDetectionAlerts": {
                    "hasInCabAudioAlertsEnabled": true,
                    "isEnabled": true
                  },
                  "harshEventSensitivity": {},
                  "harshEventSensitivityV2": {},
                  "policyViolationsDetectionAlerts": {
                    "eventsAvailableForTesting": [
                      "smoking",
                      "eatingDrinking"
                    ],
                    "eventsToCoach": [
                      "noSeatbelt",
                      "noMask"
                    ],
                    "hasInCabAudioAlertsEnabled": true,
                    "isEnabled": true,
                    "speedingThresholdMph": 5
                  },
                  "rollingStopDetectionAlerts": {
                    "isEnabled": true,
                    "speedingThresholdMph": 0
                  },
                  "safetyScoreConfiguration": {
                    "aiInattentiveDrivingDetectionWeight": 2,
                    "crashWeight": 1,
                    "defensiveDrivingWeight": 0,
                    "didNotYieldWeight": 0,
                    "drowsyWeight": 0,
                    "eatingDrinkingWeight": 0,
                    "followingDistanceModerateWeight": 0,
                    "followingDistanceSevereWeight": 0,
                    "followingDistanceWeight": 2,
                    "forwardCollisionWarningWeight": 0,
                    "harshAccelWeight": 1,
                    "harshBrakeWeight": 1,
                    "harshTurnWeight": 1,
                    "heavySpeedingWeight": 1,
                    "inattentiveDrivingWeight": 0,
                    "laneDepartureWeight": 0,
                    "lateResponseWeight": 0,
                    "lightSpeedingWeight": 0,
                    "maxSpeedWeight": 1,
                    "mobileUsageWeight": 0,
                    "moderateSpeedingWeight": 1,
                    "nearCollisionWeight": 0,
                    "noSeatbeltWeight": 0,
                    "obstructedCameraWeight": 0,
                    "ranRedLightWeight": 0,
                    "rollingStopWeight": 0,
                    "severeSpeedingWeight": 1,
                    "smokingWeight": 0,
                    "speedingWeight": 0,
                    "vulnerableRoadUserWeight": 0
                  },
                  "safetyScoreTarget": 90,
                  "speedingSettings": {
                    "severityLevels": [
                      {
                        "durationMs": 60,
                        "isEnabled": true,
                        "severityLevel": "light",
                        "speedOverLimitThreshold": 10
                      }
                    ]
                  },
                  "voiceCoaching": {
                    "eventsToCoach": [
                      "crash",
                      "inCabSpeeding",
                      "maximumSpeed"
                    ],
                    "isEnabled": true,
                    "speedingThresholdMph": 10
                  }
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/fleet/settings/safety")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Settings.GetSafetySettingsAsync();
        Assert.That(
            response,
            Is.EqualTo(
                    JsonUtils.Deserialize<SafetySettingsGetSafetySettingsResponseBody>(mockResponse)
                )
                .UsingDefaults()
        );
    }
}
