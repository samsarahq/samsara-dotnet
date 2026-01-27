using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.Core;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.OrganizationInfo;

[TestFixture]
public class GetOrganizationInfoTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": {
                "carrierSettings": {
                  "carrierName": "Acme Inc.",
                  "dotNumber": 98231,
                  "mainOfficeAddress": "1234 Pear St., Scranton, PA 62814"
                },
                "id": "123",
                "name": "Charlie's Dining Services"
              }
            }
            """;

        Server
            .Given(WireMock.RequestBuilders.Request.Create().WithPath("/me").UsingGet())
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.OrganizationInfo.GetOrganizationInfoAsync();
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<OrganizationInfoResponse>(mockResponse))
                .UsingDefaults()
        );
    }
}
