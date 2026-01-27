using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.Core;
using Samsara.Net.Drivers;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.Drivers;

[TestFixture]
public class UpdateTest : BaseMockServerTest
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
                "attributes": [
                  {
                    "id": "123e4567-e89b-12d3-a456-426614174000",
                    "name": "License Certifications"
                  }
                ],
                "carrierSettings": {
                  "carrierName": "Acme Inc.",
                  "dotNumber": 98231,
                  "homeTerminalAddress": "1234 Pear St., Scranton, PA 62814",
                  "homeTerminalName": "Acme Inc.",
                  "mainOfficeAddress": "1234 Pear St., Scranton, PA 62814"
                },
                "createdAtTime": "2019-05-18T20:27:35.000Z",
                "currentIdCardCode": "941767043",
                "driverActivationStatus": "active",
                "eldAdverseWeatherExemptionEnabled": true,
                "eldBigDayExemptionEnabled": true,
                "eldDayStartHour": 1000000,
                "eldExempt": true,
                "eldExemptReason": "Bad driver",
                "eldPcEnabled": true,
                "eldSettings": {
                  "rulesets": [
                    {
                      "jurisdiction": "AR"
                    }
                  ]
                },
                "eldYmEnabled": true,
                "externalIds": {
                  "maintenanceId": "250020",
                  "payrollId": "ABFS18600"
                },
                "hasDrivingFeaturesHidden": true,
                "hasVehicleUnpinningEnabled": true,
                "id": "123",
                "isDeactivated": false,
                "licenseNumber": "E1234567",
                "licenseState": "CA",
                "locale": "us",
                "name": "Susan Jones",
                "notes": "Also goes by the nickname Furious Fred.",
                "peerGroupTag": {
                  "id": "3914",
                  "name": "East Coast",
                  "parentTagId": "4815"
                },
                "phone": "5558234327",
                "profileImageUrl": "https://example.com/images/driver-profile.jpg",
                "staticAssignedVehicle": {
                  "id": "123456789",
                  "name": "Midwest Truck #4"
                },
                "tachographCardNumber": "1000000492436002",
                "tags": [
                  {
                    "id": "3914",
                    "name": "East Coast",
                    "parentTagId": "4815"
                  }
                ],
                "timezone": "America/Los_Angeles",
                "updatedAtTime": "2019-06-13T19:08:25.000Z",
                "usDriverRulesetOverride": {
                  "cycle": "USA Property (8/70)",
                  "restart": "34-hour Restart",
                  "restbreak": "Property (off-duty/sleeper)",
                  "usStateToOverride": ""
                },
                "username": "SusanJones",
                "vehicleGroupTag": {
                  "id": "3914",
                  "name": "East Coast",
                  "parentTagId": "4815"
                },
                "waitingTimeDutyStatusEnabled": true
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/fleet/drivers/id")
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

        var response = await Client.Drivers.UpdateAsync(new UpdateDriverRequest { Id = "id" });
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<DriverResponse>(mockResponse)).UsingDefaults()
        );
    }
}
