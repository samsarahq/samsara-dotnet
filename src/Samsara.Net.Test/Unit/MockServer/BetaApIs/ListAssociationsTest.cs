using NUnit.Framework;
using Samsara.Net.BetaApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class ListAssociationsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "associationEndTime": "associationEndTime",
                  "associationStartTime": "associationStartTime",
                  "centralId": "centralId",
                  "peripheralId": "peripheralId",
                  "peripheralName": "peripheralName"
                },
                {
                  "associationEndTime": "associationEndTime",
                  "associationStartTime": "associationStartTime",
                  "centralId": "centralId",
                  "peripheralId": "peripheralId",
                  "peripheralName": "peripheralName"
                }
              ],
              "pagination": {
                "endCursor": "endCursor",
                "hasNextPage": true
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/fleet/assets/associations")
                    .WithParam("startTime", "startTime")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.BetaApIs.ListAssociationsAsync(
            new ListAssociationsRequest { StartTime = "startTime" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
