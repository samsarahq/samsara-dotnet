using NUnit.Framework;
using Samsara.Net.Documents;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.Documents;

[TestFixture]
public class GetDocumentTypesTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "conditionalFieldSections": [
                    {
                      "conditionalFieldFirstIndex": 1,
                      "conditionalFieldLastIndex": 2,
                      "triggeringFieldIndex": 0,
                      "triggeringFieldValue": "Yes"
                    }
                  ],
                  "fieldTypes": [
                    {
                      "fieldType": "multipleChoice",
                      "label": "Was there damage?",
                      "multipleChoiceFieldTypeMetaData": [
                        {
                          "label": "Yes"
                        },
                        {
                          "label": "No"
                        }
                      ],
                      "numberFieldTypeMetaData": {
                        "numberOfDecimalPlaces": 4983279330600016000
                      },
                      "requiredField": true,
                      "signatureFieldTypeMetaData": {
                        "legalText": "Verified by signee."
                      }
                    },
                    {
                      "fieldType": "photo",
                      "label": "Damage Photos",
                      "multipleChoiceFieldTypeMetaData": [
                        {
                          "label": "Fuel Receipt"
                        }
                      ],
                      "numberFieldTypeMetaData": {
                        "numberOfDecimalPlaces": 4983279330600016000
                      },
                      "requiredField": false,
                      "signatureFieldTypeMetaData": {
                        "legalText": "Verified by signee."
                      }
                    },
                    {
                      "fieldType": "number",
                      "label": "Number of vehicles impacted",
                      "multipleChoiceFieldTypeMetaData": [
                        {
                          "label": "Fuel Receipt"
                        }
                      ],
                      "numberFieldTypeMetaData": {
                        "numberOfDecimalPlaces": 2
                      },
                      "requiredField": false,
                      "signatureFieldTypeMetaData": {
                        "legalText": "Verified by signee."
                      }
                    },
                    {
                      "fieldType": "dateTime",
                      "label": "Date and time",
                      "multipleChoiceFieldTypeMetaData": [
                        {
                          "label": "Fuel Receipt"
                        }
                      ],
                      "numberFieldTypeMetaData": {
                        "numberOfDecimalPlaces": 4983279330600016000
                      },
                      "requiredField": true,
                      "signatureFieldTypeMetaData": {
                        "legalText": "Verified by signee."
                      }
                    },
                    {
                      "fieldType": "signature",
                      "label": "Sign",
                      "multipleChoiceFieldTypeMetaData": [
                        {
                          "label": "Fuel Receipt"
                        }
                      ],
                      "numberFieldTypeMetaData": {
                        "numberOfDecimalPlaces": 4983279330600016000
                      },
                      "requiredField": true,
                      "signatureFieldTypeMetaData": {
                        "legalText": "Legal Text"
                      }
                    }
                  ],
                  "id": "4aff772c-a7bb-45e6-8e41-6a53e34feb83",
                  "name": "Accident Report",
                  "orgId": 12345
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
                    .WithPath("/fleet/document-types")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Documents.GetDocumentTypesAsync(new GetDocumentTypesRequest());
        JsonAssert.AreEqual(response, mockResponse);
    }
}
