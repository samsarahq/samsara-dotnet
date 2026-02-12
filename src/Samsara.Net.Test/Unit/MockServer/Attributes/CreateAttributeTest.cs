using NUnit.Framework;
using Samsara.Net.Attributes;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.Attributes;

[TestFixture]
public class CreateAttributeTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "attributeType": "single-select",
              "entityType": "driver",
              "name": "License Certifications"
            }
            """;

        const string mockResponse = """
            {
              "data": {
                "entities": [
                  {}
                ],
                "attributeType": "single-select",
                "entityType": "driver",
                "id": "123e4567-e89b-12d3-a456-426614174000",
                "name": "License Certifications",
                "numberValues": [
                  1.1
                ],
                "stringValues": [
                  "stringValues"
                ],
                "unit": "NO_UNIT",
                "values": [
                  {
                    "id": "123e4567-e89b-12d3-a456-426614174000",
                    "stringValue": "CDL"
                  }
                ]
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/attributes")
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

        var response = await Client.Attributes.CreateAttributeAsync(
            new CreateAttributeRequest
            {
                AttributeType = CreateAttributeRequestAttributeType.SingleSelect,
                EntityType = CreateAttributeRequestEntityType.Driver,
                Name = "License Certifications",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
