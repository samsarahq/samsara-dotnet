using NUnit.Framework;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;
using Samsara.Net.Vehicles;

namespace Samsara.Net.Test.Unit.MockServer.Vehicles;

[TestFixture]
public class GetTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": {
                "attributes": [
                  {
                    "id": "123e4567-e89b-12d3-a456-426614174000",
                    "name": "License Certifications"
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
                "esn": "11223344",
                "externalIds": {
                  "maintenanceId": "250020",
                  "payrollId": "ABFS18600"
                },
                "gateway": {
                  "model": "VG34",
                  "serial": "ABCD-123-XYZ"
                },
                "grossVehicleWeight": {
                  "unit": "lb",
                  "weight": 1000
                },
                "harshAccelerationSettingType": "passengerCar",
                "id": "112",
                "licensePlate": "XHK1234",
                "make": "Ford",
                "model": "F150",
                "name": "Truck A7",
                "notes": "These are notes about this given vehicle.",
                "sensorConfiguration": {
                  "areas": [
                    {}
                  ],
                  "doors": [
                    {}
                  ]
                },
                "serial": "VG12345",
                "staticAssignedDriver": {
                  "id": "88668",
                  "name": "Susan Bob"
                },
                "tags": [
                  {
                    "id": "3914",
                    "name": "East Coast",
                    "parentTagId": "4815"
                  }
                ],
                "vehicleRegulationMode": "regulated",
                "vehicleType": "truck",
                "vin": "1FUJA6BD31LJ09646",
                "year": "2008"
              }
            }
            """;

        Server
            .Given(
                WireMock.RequestBuilders.Request.Create().WithPath("/fleet/vehicles/id").UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Vehicles.GetAsync(new GetVehiclesRequest { Id = "id" });
        JsonAssert.AreEqual(response, mockResponse);
    }
}
