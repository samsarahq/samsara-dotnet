using NUnit.Framework;
using Samsara.Net.Maintenance;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.Maintenance;

[TestFixture]
public class ListVendorsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
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
                  "createdAtTime": "2019-06-13T19:08:25Z",
                  "defaultLaborRatePerHour": {
                    "amount": "12345",
                    "currency": "12345"
                  },
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
                  "primaryCorporateContact": {
                    "email": "12345",
                    "name": "12345",
                    "phoneNumber": "12345"
                  },
                  "status": "active",
                  "updatedAtTime": "2019-06-13T19:08:25Z"
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

        var response = await Client.Maintenance.ListVendorsAsync(new ListVendorsRequest());
        JsonAssert.AreEqual(response, mockResponse);
    }
}
