using NUnit.Framework;
using Samsara.Net.Industrial;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.Industrial;

[TestFixture]
public class V1GetVisionProgramsByCameraTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            [
              {
                "programId": 1,
                "programName": "Barcode verification program"
              }
            ]
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/industrial/vision/cameras/1000000/programs")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Industrial.V1GetVisionProgramsByCameraAsync(
            new V1GetVisionProgramsByCameraRequest { CameraId = 1000000 }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
