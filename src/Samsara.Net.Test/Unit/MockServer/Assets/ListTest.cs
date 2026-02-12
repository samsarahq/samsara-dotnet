using NUnit.Framework;
using Samsara.Net.Assets;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.Assets;

[TestFixture]
public class ListTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "createdAtTime": "2020-01-27T07:06:25Z",
                  "externalIds": {
                    "key": "value"
                  },
                  "id": "12345",
                  "licensePlate": "XHK1234",
                  "make": "Bobcat",
                  "model": "S630 T4",
                  "name": "MyAsset-1234",
                  "notes": "These are notes.",
                  "readingsIngestionEnabled": true,
                  "regulationMode": "mixed",
                  "serialNumber": "LN016251",
                  "tags": [
                    {
                      "id": "3914",
                      "name": "East Coast",
                      "parentTagId": "4815"
                    }
                  ],
                  "type": "uncategorized",
                  "updatedAtTime": "2020-01-27T07:06:25Z",
                  "vin": "1FUJBBCKXCLBZ1234",
                  "year": 2015
                }
              ],
              "pagination": {
                "endCursor": "MjkY",
                "hasNextPage": true
              }
            }
            """;

        Server
            .Given(WireMock.RequestBuilders.Request.Create().WithPath("/assets").UsingGet())
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var items = await Client.Assets.ListAsync(new ListAssetsRequest());
        await foreach (var item in items)
        {
            Assert.That(item, Is.Not.Null);
            break; // Only check the first item
        }
    }
}
