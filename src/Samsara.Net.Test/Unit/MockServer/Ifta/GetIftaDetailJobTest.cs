using NUnit.Framework;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.Ifta;

[TestFixture]
public class GetIftaDetailJobTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": {
                "args": {
                  "endHour": "2019-06-13T19:00:00Z",
                  "startHour": "2019-06-13T19:00:00Z",
                  "vehicleIds": [
                    12345678,
                    56789123
                  ]
                },
                "completedAtTime": "2019-06-13T19:00:00Z",
                "details": "Try limiting the number of vehicles requested per job to reduce the processing duration.",
                "failedAtTime": "2019-06-13T19:00:00Z",
                "files": [
                  {
                    "createdAtTime": "2019-06-13T19:00:00Z",
                    "downloadUrl": "https://s3.download-url.com",
                    "downloadUrlExpirationTime": "2019-06-13T19:00:00Z",
                    "name": "output-001.csv.gz",
                    "recordCount": 3744166038677327400
                  }
                ],
                "jobId": "8cabba84-bef4-4951-8cd2-78ce898fd8e6",
                "jobStatus": "Requested",
                "requestedAtTime": "2019-06-13T19:00:00Z",
                "startedAtTime": "2019-06-13T19:00:00Z"
              }
            }
            """;

        Server
            .Given(
                WireMock.RequestBuilders.Request.Create().WithPath("/ifta-detail/csv/id").UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Ifta.GetIftaDetailJobAsync("id");
        JsonAssert.AreEqual(response, mockResponse);
    }
}
