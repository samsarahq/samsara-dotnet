using NUnit.Framework;
using Samsara.Net.Attributes;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.Attributes;

[TestFixture]
public class GetAttributeTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
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
                    .WithParam("entityType", "driver")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Attributes.GetAttributeAsync(
            new GetAttributeRequest { Id = "id", EntityType = GetAttributeRequestEntityType.Driver }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
