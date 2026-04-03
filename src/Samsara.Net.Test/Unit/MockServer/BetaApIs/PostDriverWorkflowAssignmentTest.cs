using NUnit.Framework;
using Samsara.Net.BetaApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class PostDriverWorkflowAssignmentTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "workflowId": "a4db8702-79d5-4396-a717-e301d52ecc11"
            }
            """;

        const string mockResponse = """
            {
              "data": {
                "workflowId": "a4db8702-79d5-4396-a717-e301d52ecc11"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/fleet/drivers/workflow-assignments")
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

        var response = await Client.BetaApIs.PostDriverWorkflowAssignmentAsync(
            new DriverWorkflowAssignmentsPostDriverWorkflowAssignmentRequestBody
            {
                WorkflowId = "a4db8702-79d5-4396-a717-e301d52ecc11",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
