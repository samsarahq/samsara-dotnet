using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.Addresses;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.Addresses;

[TestFixture]
public class CreateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "formattedAddress": "350 Rhode Island St, San Francisco, CA",
              "geofence": {},
              "name": "Samsara HQ"
            }
            """;

        const string mockResponse = """
            {
              "data": {
                "addressTypes": [
                  "yard"
                ],
                "contacts": [
                  {
                    "firstName": "Jane",
                    "id": "22408",
                    "lastName": "Jones"
                  }
                ],
                "createdAtTime": "2019-05-18T20:27:35.000Z",
                "formattedAddress": "350 Rhode Island St, San Francisco, CA",
                "geofence": {
                  "circle": {
                    "latitude": 37.765363,
                    "longitude": -122.4029238,
                    "radiusMeters": 25
                  },
                  "polygon": {
                    "vertices": [
                      {
                        "latitude": 37.765363,
                        "longitude": -122.403098
                      },
                      {
                        "latitude": 38.765363,
                        "longitude": -122.403098
                      },
                      {
                        "latitude": 37.765363,
                        "longitude": -123.403098
                      }
                    ]
                  },
                  "settings": {
                    "showAddresses": false
                  }
                },
                "id": "22408",
                "latitude": 37.765363,
                "longitude": -122.4029238,
                "name": "Samsara HQ",
                "notes": "Hours of operation: 8am - 6pm; Truck entrance on the Rhode Island street side.",
                "tags": [
                  {
                    "id": "3914",
                    "name": "East Coast",
                    "parentTagId": "4815"
                  }
                ]
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/addresses")
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

        var response = await Client.Addresses.CreateAsync(
            new CreateAddressRequest
            {
                FormattedAddress = "350 Rhode Island St, San Francisco, CA",
                Geofence = new CreateAddressRequestGeofence(),
                Name = "Samsara HQ",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
