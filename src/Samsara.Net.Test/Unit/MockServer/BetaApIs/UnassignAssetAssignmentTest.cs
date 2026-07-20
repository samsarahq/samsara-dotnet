using NUnit.Framework;
using Samsara.Net.BetaApIs;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class UnassignAssetAssignmentTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public void MockServerTest()
    {
        const string requestJson = """
            {
              "assetId": "281474978683353"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/fleet/assets/assignments/unassign")
                    .WithHeader("Content-Type", "application/json")
                    .UsingPost()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(WireMock.ResponseBuilders.Response.Create().WithStatusCode(200));

        Assert.DoesNotThrowAsync(async () =>
            await Client.BetaApIs.UnassignAssetAssignmentAsync(
                new AssetAssignmentsUnassignAssetAssignmentRequestBody
                {
                    AssetId = "281474978683353",
                }
            )
        );
    }
}
