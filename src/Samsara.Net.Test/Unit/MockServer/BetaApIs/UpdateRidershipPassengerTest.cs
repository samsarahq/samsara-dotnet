using NUnit.Framework;
using Samsara.Net.BetaApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class UpdateRidershipPassengerTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "accountId": "e4b2c3a5-7d6f-4e8b-9a0c-1b2d3e4f5a6b",
              "firstName": "John",
              "lastName": "Doe"
            }
            """;

        const string mockResponse = """
            {
              "data": {
                "accountId": "e4b2c3a5-7d6f-4e8b-9a0c-1b2d3e4f5a6b",
                "classification": "grade5",
                "createdAtTime": "2024-11-15T10:00:00Z",
                "externalIds": {
                  "key": "value"
                },
                "firstName": "John",
                "id": "a1b2c3d4-5e6f-7a8b-9c0d-1e2f3a4b5c6d",
                "identifiers": [
                  {
                    "id": "b2c3d4e5-6f7a-8b9c-0d1e-2f3a4b5c6d7e",
                    "status": "active",
                    "type": "rfid",
                    "value": "0418A2BC93"
                  }
                ],
                "isActive": true,
                "lastName": "Doe",
                "specialInstructions": {
                  "isGuardianRequired": false,
                  "isSpecialEducation": true
                },
                "updatedAtTime": "2024-11-15T10:30:00Z"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/ridership/passengers")
                    .WithParam("id", "id")
                    .WithHeader("Content-Type", "application/json")
                    .UsingPut()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.BetaApIs.UpdateRidershipPassengerAsync(
            new RidershipPassengersUpdateRidershipPassengerRequestBody
            {
                Id = "id",
                AccountId = "e4b2c3a5-7d6f-4e8b-9a0c-1b2d3e4f5a6b",
                FirstName = "John",
                LastName = "Doe",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
