using NUnit.Framework;
using Samsara.Net.Fleet.CarrierProposedAssignments;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.Fleet.CarrierProposedAssignments;

[TestFixture]
public class DeleteTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            ""
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/fleet/carrier-proposed-assignments/id")
                    .UsingDelete()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Fleet.CarrierProposedAssignments.DeleteAsync(
            new DeleteCarrierProposedAssignmentsRequest { Id = "id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
