using NUnit.Framework;
using Samsara.Net.PreviewApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.PreviewApIs;

[TestFixture]
public class PostFleetInstallerPhotoUploadTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "contentMd5": "rL0Y20zC+Fzt72VPzMSk2A==",
              "deviceId": "281474977961335",
              "fileFormatType": "imageJpeg",
              "fileName": "front_camera_install.jpg",
              "hardwareType": "vehicleGateway",
              "photoType": "installPhoto",
              "sizeBytes": 482193
            }
            """;

        const string mockResponse = """
            {
              "data": {
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
                "updatedAtTime": "2026-06-01T18:15:00.000Z",
                "uploadContext": {
                  "expiresAtTime": "2026-06-01T18:30:00.000Z",
                  "headers": {
                    "Content-Length": "482193",
                    "Content-MD5": "rL0Y20zC+Fzt72VPzMSk2A==",
                    "Content-Type": "image/jpeg"
                  },
                  "uploadUrl": "https://samsara-media.s3.amazonaws.com/fleet-installer/550e8400-e29b-41d4-a716-446655440000"
                }
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/preview/fleet/installer/photo-uploads")
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

        var response = await Client.PreviewApIs.PostFleetInstallerPhotoUploadAsync(
            new FleetInstallerPhotoUploadsPostFleetInstallerPhotoUploadRequestBody
            {
                ContentMd5 = "rL0Y20zC+Fzt72VPzMSk2A==",
                DeviceId = "281474977961335",
                FileFormatType =
                    FleetInstallerPhotoUploadsPostFleetInstallerPhotoUploadRequestBodyFileFormatType.ImageJpeg,
                FileName = "front_camera_install.jpg",
                HardwareType =
                    FleetInstallerPhotoUploadsPostFleetInstallerPhotoUploadRequestBodyHardwareType.VehicleGateway,
                PhotoType =
                    FleetInstallerPhotoUploadsPostFleetInstallerPhotoUploadRequestBodyPhotoType.InstallPhoto,
                SizeBytes = 482193,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
