using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.Alerts;
using Samsara.Net.Core;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.Alerts;

[TestFixture]
public class PostConfigurationsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "actions": [
                {
                  "actionTypeId": 1
                }
              ],
              "isEnabled": true,
              "name": "My Harsh Event Alert",
              "scope": {
                "all": true
              },
              "triggers": [
                {
                  "triggerTypeId": 1000
                }
              ]
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
                "createdAtTime": "2019-06-13T19:08:25.000Z",
                "externalIds": {
                  "key": "value"
                },
                "id": "e1c5dffc-c7b7-47b0-a778-6a65de638abf",
                "isEnabled": true,
                "lastModifiedAtTime": "2019-06-13T19:08:25.000Z",
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
                    .UsingPost()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Alerts.PostConfigurationsAsync(
            new AlertsPostConfigurationsRequestBody
            {
                Actions = new List<ActionObjectRequestBody>()
                {
                    new ActionObjectRequestBody { ActionTypeId = 1 },
                },
                IsEnabled = true,
                Name = "My Harsh Event Alert",
                Scope = new ScopeObjectRequestBody { All = true },
                Triggers = new List<WorkflowTriggerObjectRequestBody>()
                {
                    new WorkflowTriggerObjectRequestBody { TriggerTypeId = 1000 },
                },
            }
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<AlertsPostConfigurationsResponseBody>(mockResponse))
                .UsingDefaults()
        );
    }
}
