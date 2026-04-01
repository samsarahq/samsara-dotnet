using NUnit.Framework;
using Samsara.Net.BetaApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class ListTachographLiveDataTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "cumulatedDrivingTimePreviousAndCurrentWeekMinute": 12345,
                  "cumulativeBreakTimeMinute": 12345,
                  "currentDailyDrivingTimeMinute": 12345,
                  "currentDurationOfSelectedActivityMinute": 12345,
                  "currentWeeklyDrivingTimeMinute": 12345,
                  "driverId": "12345",
                  "durationOfNextBreakRestMinute": 12345,
                  "durationOfNextDrivingPeriodMinute": 12345,
                  "endOfLastDailyRestPeriod": "2019-06-13T19:08:25Z",
                  "endOfLastWeeklyRestPeriod": "2019-06-13T19:08:25Z",
                  "happenedAtTime": "2019-06-13T19:08:25Z",
                  "maximumDailyDrivingTimeMinute": 12345,
                  "minimumDailyRestMinute": 12345,
                  "minimumWeeklyRestMinute": 12345,
                  "numberOfTimes9hDailyDrivingTimesExceeded": 12345,
                  "numberOfUsedReducedDailyRestPeriods": 12345,
                  "openCompensationInSecondWeekBeforeLastMinute": 12345,
                  "openCompensationInTheLastWeekMinute": 12345,
                  "openCompensationInWeekBeforeLastMinute": 12345,
                  "remaining2WeeksDrivingTimeMinute": 12345,
                  "remainingCurrentDrivingTimeMinute": 12345,
                  "remainingDrivingTimeOfCurrentWeekMinute": 12345,
                  "remainingDrivingTimeOnCurrentShiftMinute": 12345,
                  "remainingTimeOfCurrentBreakRestMinute": 12345,
                  "remainingTimeUntilNextBreakOrRestMinute": 12345,
                  "tachographCardNumber": "12345",
                  "timeLeftUntilNewDailyRestPeriodMinute": 12345,
                  "timeLeftUntilNewWeeklyRestPeriodMinute": 12345,
                  "timeLeftUntilNextDrivingPeriodMinute": 12345,
                  "vehicleId": "12345",
                  "workingState": "12345"
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
                    .WithPath("/fleet/tachograph-live-data/latest")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.BetaApIs.ListTachographLiveDataAsync(
            new ListTachographLiveDataRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
