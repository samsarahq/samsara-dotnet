using NUnit.Framework;
using Samsara.Net.Media;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.Media;

[TestFixture]
public class PostMediaRetrievalTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "endTime": "2019-06-13T19:08:55Z",
              "inputs": [
                "dashcamRoadFacing",
                "dashcamRoadFacing",
                "dashcamRoadFacing"
              ],
              "mediaType": "image",
              "startTime": "2019-06-13T19:08:25Z",
              "vehicleId": "1234"
            }
            """;

        const string mockResponse = """
            {
              "data": {
                "quotaStatus": "Current monthly usage is 80000.4 seconds of high-res video out of 900000.0 available.",
                "retrievalId": "2308cec4-82e0-46f1-8b3c-a3592e5cc21e"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/cameras/media/retrieval")
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

        var response = await Client.Media.PostMediaRetrievalAsync(
            new MediaRetrievalPostMediaRetrievalRequestBody
            {
                EndTime = "2019-06-13T19:08:55Z",
                Inputs = new List<MediaRetrievalPostMediaRetrievalRequestBodyInputsItem>()
                {
                    MediaRetrievalPostMediaRetrievalRequestBodyInputsItem.DashcamRoadFacing,
                    MediaRetrievalPostMediaRetrievalRequestBodyInputsItem.DashcamRoadFacing,
                    MediaRetrievalPostMediaRetrievalRequestBodyInputsItem.DashcamRoadFacing,
                },
                MediaType = MediaRetrievalPostMediaRetrievalRequestBodyMediaType.Image,
                StartTime = "2019-06-13T19:08:25Z",
                VehicleId = "1234",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
