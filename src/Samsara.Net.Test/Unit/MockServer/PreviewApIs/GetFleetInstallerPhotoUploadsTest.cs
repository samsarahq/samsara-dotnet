using NUnit.Framework;
using Samsara.Net.PreviewApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.PreviewApIs;

[TestFixture]
public class GetFleetInstallerPhotoUploadsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "contentMd5": "rL0Y20zC+Fzt72VPzMSk2A==",
                  "createdAtTime": "2026-06-01T18:15:00.000Z",
                  "deviceId": "281474977961335",
                  "fileFormatType": "imageJpeg",
                  "fileName": "front_camera_install.jpg",
                  "hardwareType": "vehicleGateway",
                  "id": "550e8400-e29b-41d4-a716-446655440000",
                  "photoType": "installPhoto",
                  "processingStatus": "awaitingUpload",
                  "sizeBytes": 482193,
                  "updatedAtTime": "2026-06-01T18:15:00.000Z"
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
                    .WithPath("/preview/fleet/installer/photo-uploads")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.PreviewApIs.GetFleetInstallerPhotoUploadsAsync(
            new GetFleetInstallerPhotoUploadsRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
