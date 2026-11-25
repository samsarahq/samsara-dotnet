using NUnit.Framework;
using Samsara.Net.BetaApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class GetRecallsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "campaignId": "2d0e5e9b-4b2a-4e4e-9b8e-6c3f8a7d1e2f",
                  "component": "SERVICE BRAKES, AIR",
                  "consequence": "A damaged hose can reduce braking and increase the risk of a crash.",
                  "dismissReason": "Units already repaired by dealer",
                  "dismissedAtTime": "2026-03-10T15:04:05.000Z",
                  "documents": [
                    {
                      "documentType": "Recall 573 Report",
                      "documentUrl": "https://static.nhtsa.gov/odi/rcl/2026/RCLRPT-26V127-1234.PDF",
                      "fileName": "RCLRPT-26V127-1234.PDF",
                      "loadedAtTime": "2026-03-02T00:00:00.000Z"
                    }
                  ],
                  "hasDoNotDriveAdvisory": false,
                  "hasParkOutsideAdvisory": false,
                  "id": "26V127000",
                  "isBroadMatch": false,
                  "isDismissed": false,
                  "isOverTheAirRemedy": false,
                  "isReturnedAfterDismissal": false,
                  "manufacturer": "Daimler Truck North America",
                  "manufacturerRecallNumber": "FL-1042",
                  "matchedAssetCount": 14,
                  "potentiallyAffectedUnitCount": 12430,
                  "products": [
                    {
                      "make": "FREIGHTLINER",
                      "manufactureEndTime": "2024-02-29T00:00:00.000Z",
                      "manufactureStartTime": "2023-06-01T00:00:00.000Z",
                      "model": "CASCADIA",
                      "year": 2024
                    }
                  ],
                  "recallSource": "recallMasters",
                  "remedy": "Dealers will inspect and reroute the hose, free of charge.",
                  "reportTime": "2026-03-02T00:00:00.000Z",
                  "sourceUrl": "https://www.nhtsa.gov/?nhtsaId=26V127000",
                  "subject": "Rear brake hose may chafe",
                  "summary": "The rear brake hose may chafe against the frame."
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
                    .WithPath("/maintenance/recalls")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.BetaApIs.GetRecallsAsync(new GetRecallsRequest());
        JsonAssert.AreEqual(response, mockResponse);
    }
}
