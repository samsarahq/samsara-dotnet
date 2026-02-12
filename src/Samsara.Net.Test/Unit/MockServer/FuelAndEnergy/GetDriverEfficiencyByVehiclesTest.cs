using NUnit.Framework;
using Samsara.Net.FuelAndEnergy;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.FuelAndEnergy;

[TestFixture]
public class GetDriverEfficiencyByVehiclesTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "difficultyScore": {
                    "overallScore": "4",
                    "topographyScore": "5",
                    "vehicleWeightScore": "4"
                  },
                  "percentageData": {
                    "anticipationPercentage": 9.5,
                    "coastingPercentage": 45.6,
                    "cruiseControlPercentage": 45.6,
                    "greenBandPercentage": 78.9,
                    "highGradeRoadDrivingPercentage": 15.3,
                    "highTorquePercentage": 23.4,
                    "idlingPercentage": 12.8,
                    "overSpeedPercentage": 5.6,
                    "wearFreeBrakePercentage": 88.2
                  },
                  "rawData": {
                    "anticipationBrakeEventCount": 17,
                    "averageVehicleWeightKg": 14500,
                    "coastingDurationMs": 1900800,
                    "cruiseControlDurationMs": 3283200,
                    "driveTimeDurationMs": 7200000,
                    "engineOnDurationMs": 7500000,
                    "greenBandDurationMs": 5683200,
                    "highGradeRoadDrivingDurationMs": 1108800,
                    "highTorqueDurationMs": 1684800,
                    "idlingDurationMs": 921600,
                    "overSpeedDurationMs": 403200,
                    "totalBrakeDurationMs": 1022400,
                    "totalBrakeEventCount": 85,
                    "wearFreeBrakeDurationMs": 6340800
                  },
                  "scoreData": {
                    "anticipationScore": "C",
                    "coastingScore": "C",
                    "cruiseControlScore": "B",
                    "greenBandScore": "A",
                    "highTorqueScore": "A",
                    "idlingScore": "B",
                    "overSpeedScore": "B",
                    "overallScore": "A",
                    "wearFreeBrakeScore": "A"
                  },
                  "vehicleId": "vehicle_001"
                }
              ],
              "pagination": {
                "endCursor": "MjkY",
                "hasNextPage": true
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/driver-efficiency/vehicles")
                    .WithParam("startTime", "startTime")
                    .WithParam("endTime", "endTime")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.FuelAndEnergy.GetDriverEfficiencyByVehiclesAsync(
            new GetDriverEfficiencyByVehiclesRequest
            {
                StartTime = "startTime",
                EndTime = "endTime",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
