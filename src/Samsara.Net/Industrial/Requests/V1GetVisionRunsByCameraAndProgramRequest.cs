using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Industrial;

[Serializable]
public record V1GetVisionRunsByCameraAndProgramRequest
{
    /// <summary>
    /// The camera_id should be valid for the given accessToken.
    /// </summary>
    [JsonIgnore]
    public required long CameraId { get; set; }

    /// <summary>
    /// The configured program's ID on the camera.
    /// </summary>
    [JsonIgnore]
    public required long ProgramId { get; set; }

    /// <summary>
    /// Started_at_ms is a required param. Indicates the start time of the run to be fetched.
    /// </summary>
    [JsonIgnore]
    public required long StartedAtMs { get; set; }

    /// <summary>
    /// Include is a filter parameter. Accepts 'pass', 'reject' or 'no_read'.
    /// </summary>
    [JsonIgnore]
    public string? Include { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
