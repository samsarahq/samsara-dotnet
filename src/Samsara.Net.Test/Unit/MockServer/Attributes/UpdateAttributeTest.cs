using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.Attributes;
using Samsara.Net.Core;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.Attributes;

[TestFixture]
public class UpdateAttributeTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "entityType": "driver"
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
                    .WithPath("/attributes/id")
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

        var response = await Client.Attributes.UpdateAttributeAsync(
            new UpdateAttributeRequest
            {
                Id = "id",
                EntityType = UpdateAttributeRequestEntityType.Driver,
            }
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<AttributeExpandedResponse>(mockResponse))
                .UsingDefaults()
        );
    }
}
