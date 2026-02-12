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
                        "TUESDAY",
                        "SUNDAY",
                        "TUESDAY"
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
