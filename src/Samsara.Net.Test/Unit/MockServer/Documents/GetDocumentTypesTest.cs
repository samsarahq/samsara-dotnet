using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.Core;
using Samsara.Net.Documents;
using Samsara.Net.Test.Unit.MockServer;

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
                      "requiredField": true
                    },
                    {
                      "fieldType": "photo",
                      "label": "Damage Photos",
                      "requiredField": false
                    },
                    {
                      "fieldType": "number",
                      "label": "Number of vehicles impacted",
                      "numberFieldTypeMetaData": {
                        "numberOfDecimalPlaces": 2
                      },
                      "requiredField": false
                    },
                    {
                      "fieldType": "dateTime",
                      "label": "Date and time",
                      "requiredField": true
                    },
                    {
                      "fieldType": "signature",
                      "label": "Sign",
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
        Assert.That(
            response,
            Is.EqualTo(
                    JsonUtils.Deserialize<DocumentTypesGetDocumentTypesResponseBody>(mockResponse)
                )
                .UsingDefaults()
        );
    }
}
