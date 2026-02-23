using NUnit.Framework;
using Samsara.Net.Maintenance;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.Maintenance;

[TestFixture]
public class CreateDvirTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "authorId": "11",
              "safetyStatus": "safe",
              "type": "mechanic"
            }
            """;

        const string mockResponse = """
            {
              "data": {
                "authorSignature": {
                  "signatoryUser": {
                    "id": "88668",
                    "name": "Susan Bob"
                  },
                  "signedAtTime": "2020-01-27T07:06:25Z",
                  "type": "driver"
                },
                "endTime": "2020-01-27T07:06:25Z",
                "id": "7107471",
                "licensePlate": "XHK1234",
                "location": "350 Rhode Island St Ste. 400S, San Francisco, CA 94103",
                "mechanicNotes": "Replaced headlight on passenger side.",
                "odometerMeters": 14010293,
                "safetyStatus": "safe",
                "secondSignature": {
                  "signatoryUser": {
                    "id": "88668",
                    "name": "Susan Bob"
                  },
                  "signedAtTime": "2020-01-27T07:06:25Z",
                  "type": "driver"
                },
                "startTime": "2020-01-27T07:06:25Z",
                "thirdSignature": {
                  "signatoryUser": {
                    "id": "88668",
                    "name": "Susan Bob"
                  },
                  "signedAtTime": "2020-01-27T07:06:25Z",
                  "type": "driver"
                },
                "trailer": {
                  "id": "123456789",
                  "name": "Midwest Trailer #5"
                },
                "trailerDefects": [
                  {
                    "comment": "Air Compressor not working",
                    "createdAtTime": "2020-01-27T07:06:25Z",
                    "defectType": "Air Compressor",
                    "id": "18",
                    "isResolved": true,
                    "mechanicNotes": "Extremely large oddly shaped hole in passenger side window.",
                    "mechanicNotesUpdatedAtTime": "2020-01-27T07:06:25Z",
                    "resolvedAtTime": "2020-01-27T07:06:25Z"
                  }
                ],
                "trailerName": "Midwest Trailer #5",
                "type": "preTrip",
                "vehicle": {
                  "ExternalIds": {
                    "maintenanceId": "250020",
                    "payrollId": "ABFS18600"
                  },
                  "id": "123456789",
                  "name": "Midwest Truck #4"
                },
                "vehicleDefects": [
                  {
                    "comment": "Air Compressor not working",
                    "createdAtTime": "2020-01-27T07:06:25Z",
                    "defectType": "Air Compressor",
                    "id": "18",
                    "isResolved": true,
                    "mechanicNotes": "Extremely large oddly shaped hole in passenger side window.",
                    "mechanicNotesUpdatedAtTime": "2020-01-27T07:06:25Z",
                    "resolvedAtTime": "2020-01-27T07:06:25Z"
                  }
                ]
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/fleet/dvirs")
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

        var response = await Client.Maintenance.CreateDvirAsync(
            new CreateDvirRequest
            {
                AuthorId = "11",
                SafetyStatus = CreateDvirRequestSafetyStatus.Safe,
                Type = CreateDvirRequestType.Mechanic,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
