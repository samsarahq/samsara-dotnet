using NUnit.Framework;
using Samsara.Net.Maintenance;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.Maintenance;

[TestFixture]
public class UpdateVendorLocationTest : BaseMockServerTest
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
                "assetAttributeSelections": [
                  {
                    "attributeId": "12345",
                    "values": [
                      {
                        "id": "12345"
                      }
                    ]
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
                "parentVendorId": "12345",
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
                "vendorId": "12345"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/fleet/maintenance/vendor-locations")
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

        var response = await Client.Maintenance.UpdateVendorLocationAsync(
            new EntityVendorsServiceUpdateVendorLocationRequestBody { Id = "id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
