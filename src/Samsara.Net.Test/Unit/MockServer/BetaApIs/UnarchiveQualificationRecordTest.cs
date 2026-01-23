using NUnit.Framework;
using Samsara.Net.BetaApIs;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class UnarchiveQualificationRecordTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public void MockServerTest()
    {
        const string requestJson = """
            {
              "id": "9814a1fa-f0c6-408b-bf85-51dc3bc71ac7"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/qualification-records/unarchive")
                    .WithHeader("Content-Type", "application/json")
                    .UsingPost()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(WireMock.ResponseBuilders.Response.Create().WithStatusCode(200));

        Assert.DoesNotThrowAsync(async () =>
            await Client.BetaApIs.UnarchiveQualificationRecordAsync(
                new QualificationsUnarchiveQualificationRecordRequestBody
                {
                    Id = "9814a1fa-f0c6-408b-bf85-51dc3bc71ac7",
                }
            )
        );
    }
}
