using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.Core;
using Samsara.Net.Forms;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.Forms;

[TestFixture]
public class GetFormTemplatesTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "approvalConfig": {
                    "singleApprovalConfig": {
                      "allowManualApproverSelection": true,
                      "requirements": {
                        "roleIds": [
                          "23d4d8d3-dc10-4e7a-a183-69968751f23e"
                        ]
                      }
                    },
                    "type": "singleApproval"
                  },
                  "createdAtTime": "2019-06-13T19:08:25.000Z",
                  "createdBy": {
                    "id": "938172",
                    "type": "driver"
                  },
                  "description": "This is a form template description.",
                  "fields": [
                    {
                      "allowManualEntry": true,
                      "allowedAssetTypes": [
                        "vehicle",
                        "trailer"
                      ],
                      "autofillFromId": "9814a1fa-f0c6-408b-bf85-51dc3bc71ac7",
                      "columns": [
                        {
                          "allowManualEntry": true,
                          "filterByRoleIds": [
                            "23d4d8d3-dc10-4e7a-a183-69968751f23e"
                          ],
                          "id": "9814a1fa-f0c6-408b-bf85-51dc3bc71ac7",
                          "includeDrivers": true,
                          "includeUsers": true,
                          "label": "Engine Hours",
                          "numDecimalPlaces": 2,
                          "options": [
                            {
                              "id": "e879028d-bce5-0238-ffec-11cd9236bcda",
                              "ignoreQuestionFromScoreIfSelected": false,
                              "label": "Yes",
                              "optionScoreWeight": 5
                            }
                          ],
                          "type": "number"
                        }
                      ],
                      "filterByRoleIds": [
                        "23d4d8d3-dc10-4e7a-a183-69968751f23e"
                      ],
                      "id": "9814a1fa-f0c6-408b-bf85-51dc3bc71ac7",
                      "includeDrivers": true,
                      "includeUsers": true,
                      "isAutofillSource": true,
                      "isRequired": true,
                      "label": "Engine Hours",
                      "numDecimalPlaces": 2,
                      "options": [
                        {
                          "id": "e879028d-bce5-0238-ffec-11cd9236bcda",
                          "ignoreQuestionFromScoreIfSelected": false,
                          "label": "Yes",
                          "optionScoreWeight": 5
                        }
                      ],
                      "questionWeight": 5,
                      "type": "number"
                    }
                  ],
                  "formCategory": "general",
                  "id": "9814a1fa-f0c6-408b-bf85-51dc3bc71ac7",
                  "revisionId": "1214a1fa-f0c6-408b-bf85-51dc3bc71ac7",
                  "sections": [
                    {
                      "fieldIndexFirstInclusive": 0,
                      "fieldIndexLastInclusive": 9,
                      "id": "dbab5bc8-e41c-4b52-bfa5-fd2c7e809b00",
                      "label": "Engine Hours"
                    }
                  ],
                  "title": "Form Template Title",
                  "updatedAtTime": "2019-06-13T19:08:25.000Z",
                  "updatedBy": {
                    "id": "938172",
                    "type": "driver"
                  }
                }
              ],
              "pagination": {
                "endCursor": "MjkY",
                "hasNextPage": true
              }
            }
            """;

        Server
            .Given(WireMock.RequestBuilders.Request.Create().WithPath("/form-templates").UsingGet())
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Forms.GetFormTemplatesAsync(new GetFormTemplatesRequest());
        Assert.That(
            response,
            Is.EqualTo(
                    JsonUtils.Deserialize<FormTemplatesGetFormTemplatesResponseBody>(mockResponse)
                )
                .UsingDefaults()
        );
    }
}
