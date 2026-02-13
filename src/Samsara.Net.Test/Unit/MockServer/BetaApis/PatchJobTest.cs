using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.BetaApis;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApis;

[TestFixture]
public class PatchJobTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "job": {}
            }
            """;

        const string mockResponse = """
            {
              "data": {
                "address": {
                  "address": "1990 Alameda st, San Francisco, Ca 94103",
                  "latitude": 37.456345,
                  "longitude": 34.5633749,
                  "name": "Worksite #1"
                },
                "createdAt": "2019-06-13T19:08:25Z",
                "customerName": "Samsara",
                "endDate": "2019-06-13T19:08:25Z",
                "fleetDevices": [
                  {
                    "id": 123456,
                    "name": "My Device"
                  }
                ],
                "id": "1553",
                "industrialAssets": [
                  {
                    "id": "8d218e6c-7a16-4f9f-90f7-cc1d93b9e596",
                    "name": "My asset"
                  }
                ],
                "modifiedAt": "2019-06-13T19:08:25Z",
                "name": "My Job Name",
                "notes": "These are my notes",
                "ontimeWindowAfterArrivalMs": 300000,
                "ontimeWindowBeforeArrivalMs": 300000,
                "startDate": "2019-06-13T19:08:25Z",
                "status": "active",
                "uuid": "8d218e6c-7a16-4f9f-90f7-cc1d93b9e596"
              },
              "id": "1553",
              "uuid": "8d218e6c-7a16-4f9f-90f7-cc1d93b9e596"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/beta/industrial/jobs")
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

        var response = await Client.BetaApis.PatchJobAsync(
            new JobsPatchJobRequestBody { Id = "id", Job = new PatchJobObjectRequestBody() }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
