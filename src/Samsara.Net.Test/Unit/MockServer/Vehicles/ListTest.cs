using NUnit.Framework;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Vehicles;

namespace Samsara.Net.Test.Unit.MockServer.Vehicles;

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
                  "attributes": [
                    {
                      "dateValues": [
                        "2024-01-15",
                        "2024-12-31"
                      ],
                      "id": "494123",
                      "name": "Compliance/ELD",
                      "numberValues": [
                        867,
                        5309
                      ],
                      "stringValues": [
                        "HQ",
                        "Leased"
                      ]
                    }
                  ],
                  "auxInputType1": "boom",
                  "auxInputType10": "boom",
                  "auxInputType11": "boom",
                  "auxInputType12": "boom",
                  "auxInputType13": "boom",
                  "auxInputType2": "boom",
                  "auxInputType3": "boom",
                  "auxInputType4": "boom",
                  "auxInputType5": "boom",
                  "auxInputType6": "boom",
                  "auxInputType7": "boom",
                  "auxInputType8": "boom",
                  "auxInputType9": "boom",
                  "cameraSerial": "CNCK-VT8-XA8",
                  "createdAtTime": "1974-05-23T00:43:14.000Z",
                  "esn": "56349811",
                  "externalIds": {
                    "key": "value"
                  },
                  "gateway": {
                    "model": "AG15",
                    "serial": "GFRV-43N-VGX"
                  },
                  "harshAccelerationSettingType": "off",
                  "id": "494123",
                  "isRemotePrivacyButtonEnabled": true,
                  "licensePlate": "6SAM123",
                  "make": "Ford",
                  "model": "F150",
                  "name": "Fleet Truck #1",
                  "notes": "These are notes about this given vehicle.",
                  "sensorConfiguration": {
                    "doors": [
                      {
                        "position": "back",
                        "sensor": {
                          "id": "12345",
                          "mac": "00:00:5e:00:53:af",
                          "name": "Rear temperature sensor"
                        }
                      }
                    ]
                  },
                  "serial": "VG12345",
                  "staticAssignedDriver": {
                    "id": "0987",
                    "name": "Driver Name"
                  },
                  "tags": [
                    {
                      "id": "3914",
                      "name": "East Coast",
                      "parentTagId": "4815"
                    }
                  ],
                  "updatedAtTime": "1973-01-02T14:33:50.000Z",
                  "vehicleRegulationMode": "regulated",
                  "vehicleType": "unset",
                  "vehicleWeight": 1000,
                  "vehicleWeightInKilograms": 1000,
                  "vehicleWeightInPounds": 2200,
                  "vin": "1GBJ6P1B2HV112765",
                  "year": "2008"
                }
              ],
              "pagination": {
                "endCursor": "MjkY",
                "hasNextPage": true
              }
            }
            """;

        Server
            .Given(WireMock.RequestBuilders.Request.Create().WithPath("/fleet/vehicles").UsingGet())
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var items = await Client.Vehicles.ListAsync(new ListVehiclesRequest());
        await foreach (var item in items)
        {
            Assert.That(item, Is.Not.Null);
            break; // Only check the first item
        }
    }
}
