using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.Core;
using Samsara.Net.Industrial;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.Industrial;

[TestFixture]
public class GetDataInputsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "assetId": "74771078-5edb-4733-88f2-7242f520d1f1",
                  "dataGroup": "Flow",
                  "id": "id",
                  "name": "Pump Flow",
                  "units": "Gallons Per Minute"
                }
              ],
              "pagination": {
                "endCursor": "MjkY",
                "hasNextPage": true
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/industrial/data-inputs")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Industrial.GetDataInputsAsync(new GetDataInputsRequest());
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<DataInputsTinyResponse>(mockResponse)).UsingDefaults()
        );
    }
}
