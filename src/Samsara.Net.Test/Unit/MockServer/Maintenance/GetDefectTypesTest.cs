using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.Core;
using Samsara.Net.Maintenance;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.Maintenance;

[TestFixture]
public class GetDefectTypesTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "createdAtTime": "2020-01-27T07:06:25.000Z",
                  "id": "25d6151e-29b5-453e-875a-7c5425332e09",
                  "label": "Air Compressor",
                  "sectionType": "exteriorFront"
                }
              ],
              "pagination": {
                "endCursor": "MjkY",
                "hasNextPage": true
              }
            }
            """;

        Server
            .Given(WireMock.RequestBuilders.Request.Create().WithPath("/defect-types").UsingGet())
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Maintenance.GetDefectTypesAsync(new GetDefectTypesRequest());
        Assert.That(
            response,
            Is.EqualTo(
                    JsonUtils.Deserialize<DvirDefectTypeGetDefectTypesResponseBody>(mockResponse)
                )
                .UsingDefaults()
        );
    }
}
