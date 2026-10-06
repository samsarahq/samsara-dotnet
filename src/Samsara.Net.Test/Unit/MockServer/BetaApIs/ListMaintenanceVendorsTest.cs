using NUnit.Framework;
using Samsara.Net.BetaApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class ListMaintenanceVendorsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "addressId": "281474993384538",
                  "assetAttributeSelections": [
                    {
                      "attributeId": "11111111-1111-4111-8111-111111111111",
                      "values": [
                        {
                          "id": "11111111-1111-4111-8111-111111111111"
                        }
                      ]
                    }
                  ],
                  "categoryIds": [
                    "a1b2c3d4-e5f6-7890-abcd-ef1234567890",
                    "a1b2c3d4-e5f6-7890-abcd-ef1234567890",
                    "a1b2c3d4-e5f6-7890-abcd-ef1234567890",
                    "a1b2c3d4-e5f6-7890-abcd-ef1234567890"
                  ],
                  "defaultLaborRatePerHour": {
                    "amount": "140.00",
                    "currency": "USD"
                  },
                  "externalIds": {
                    "key": "value"
                  },
                  "id": "9814a1fa-f0c6-408b-bf85-51dc3bc71ac7",
                  "isMobile": false,
                  "isPreferred": false,
                  "name": "Acme Tire & Service",
                  "payeeId": "PAYEE-12345",
                  "resolvedSettings": {
                    "assetAttributeSelections": [
                      {
                        "attributeId": "11111111-1111-4111-8111-111111111111",
                        "values": [
                          {
                            "id": "11111111-1111-4111-8111-111111111111"
                          }
                        ]
                      }
                    ],
                    "assetAttributeSelectionsSource": "system",
                    "defaultLaborRatePerHour": {
                      "amount": "140.00",
                      "currency": "USD"
                    },
                    "defaultLaborRatePerHourSource": "system",
                    "isActive": false,
                    "isMobile": false,
                    "isMobileSource": "system",
                    "isPreferred": false,
                    "isPreferredSource": "system"
                  },
                  "servicesProvided": "Oil changes, tire rotations, brake services",
                  "status": "active",
                  "vendorGroupId": "11111111-1111-4111-8111-111111111111",
                  "vendorId": "0000000772"
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
                    .WithPath("/fleet/maintenance/vendors")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.BetaApIs.ListMaintenanceVendorsAsync(
            new ListMaintenanceVendorsRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
