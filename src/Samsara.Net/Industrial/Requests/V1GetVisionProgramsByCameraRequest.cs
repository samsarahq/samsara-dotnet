using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Industrial;

[Serializable]
public record V1GetVisionProgramsByCameraRequest
{
    /// <summary>
    /// The camera_id should be valid for the given accessToken.
    /// </summary>
    [JsonIgnore]
    public required long CameraId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
