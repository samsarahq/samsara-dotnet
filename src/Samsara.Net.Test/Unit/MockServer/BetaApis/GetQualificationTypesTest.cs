using NUnit.Framework;
using Samsara.Net.BetaApis;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApis;

[TestFixture]
public class GetQualificationTypesTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "createdAtTime": "2019-06-13T19:08:25.000Z",
                  "createdBy": {
                    "id": "938172",
                    "type": "driver"
                  },
                  "entityType": "worker",
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
                  "id": "9814a1fa-f0c6-408b-bf85-51dc3bc71ac7",
                  "name": "Driver License",
                  "revisionId": "1214a1fa-f0c6-408b-bf85-51dc3bc71ac7",
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
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/qualification-types")
                    .WithParam("entityType", "worker")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.BetaApis.GetQualificationTypesAsync(
            new GetQualificationTypesRequest
            {
                EntityType = GetQualificationTypesRequestEntityType.Worker,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
