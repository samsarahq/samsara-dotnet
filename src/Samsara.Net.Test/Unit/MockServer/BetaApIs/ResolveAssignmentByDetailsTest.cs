using NUnit.Framework;
using Samsara.Net.BetaApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class ResolveAssignmentByDetailsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "driverName": "Jane Doe",
              "vehicleId": "281474978683353"
            }
            """;

        const string mockResponse = """
            {
              "data": {
                "driverId": "1234567",
                "driverName": "Jane Doe"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/fleet/drivers/voice-sign-in/resolve-assignment")
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

        var response = await Client.BetaApIs.ResolveAssignmentByDetailsAsync(
            new ResolveAssignmentByDetailsResolveAssignmentByDetailsRequestBody
            {
                DriverName = "Jane Doe",
                VehicleId = "281474978683353",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
