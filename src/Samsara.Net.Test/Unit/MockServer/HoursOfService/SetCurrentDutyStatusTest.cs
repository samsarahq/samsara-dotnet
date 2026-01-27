using NUnit.Framework;
using Samsara.Net.HoursOfService;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.HoursOfService;

[TestFixture]
public class SetCurrentDutyStatusTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public void MockServerTest()
    {
        const string requestJson = """
            {
              "duty_status": "ON_DUTY"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/fleet/drivers/1000000/hos/duty_status")
                    .WithHeader("Content-Type", "application/json")
                    .UsingPost()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(WireMock.ResponseBuilders.Response.Create().WithStatusCode(200));

        Assert.DoesNotThrowAsync(async () =>
            await Client.HoursOfService.SetCurrentDutyStatusAsync(
                new InlineObject1 { DriverId = 1000000, DutyStatus = "ON_DUTY" }
            )
        );
    }
}
