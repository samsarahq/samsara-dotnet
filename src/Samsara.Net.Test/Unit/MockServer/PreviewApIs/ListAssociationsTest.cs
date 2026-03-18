using NUnit.Framework;
using Samsara.Net.PreviewApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.PreviewApIs;

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
                  "peripheralId": "peripheralId",
                  "peripheralName": "peripheralName",
                  "vehicleId": "vehicleId"
                },
                {
                  "associationEndTime": "associationEndTime",
                  "associationStartTime": "associationStartTime",
                  "peripheralId": "peripheralId",
                  "peripheralName": "peripheralName",
                  "vehicleId": "vehicleId"
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
                    .WithPath("/preview/fleet/assets/associations")
                    .WithParam("startTime", "startTime")
                    .WithParam("endTime", "endTime")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.PreviewApIs.ListAssociationsAsync(
            new ListAssociationsRequest { StartTime = "startTime", EndTime = "endTime" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
