using NUnit.Framework;
using Samsara.Net.BetaApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class UpdateVendorTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {}
            """;

        const string mockResponse = """
            {
              "data": {
                "address": "12345",
                "assetAttributeSelections": [
                  {
                    "attributeId": "12345"
                  }
                ],
                "contacts": [
                  {
                    "email": "12345",
                    "name": "12345",
                    "phoneNumber": "12345"
                  }
                ],
                "defaultLaborRatePerHour": {
                  "amount": "12345",
                  "currency": "12345"
                },
                "emailAddresses": [
                  "12345",
                  "12345"
                ],
                "externalId": "12345",
                "externalIds": [
                  {
                    "key": "12345",
                    "value": "12345"
                  }
                ],
                "id": "12345",
                "isMobile": true,
                "isPreferred": true,
                "name": "12345",
                "notes": "12345",
                "payeeId": "12345",
                "phoneNumbers": [
                  "12345",
                  "12345",
                  "12345",
                  "12345"
                ],
                "placeId": {
                  "id": "281474976710656"
                },
                "servicesProvided": "12345",
                "status": "active",
                "vendorGroupId": "12345",
                "vendorId": "12345"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/fleet/maintenance/vendors")
                    .WithParam("id", "id")
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

        var response = await Client.BetaApIs.UpdateVendorAsync(
            new EntityVendorsServiceUpdateVendorRequestBody { Id = "id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
