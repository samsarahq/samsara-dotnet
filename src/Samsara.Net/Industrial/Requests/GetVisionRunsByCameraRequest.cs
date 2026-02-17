using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Industrial;

[Serializable]
public record GetVisionRunsByCameraRequest
{
    /// <summary>
    /// The camera_id should be valid for the given accessToken.
    /// </summary>
    [JsonIgnore]
    public required long CameraId { get; set; }

    /// <summary>
    /// DurationMs is a required param. This works with the EndMs parameter. Indicates the duration in which the visionRuns will be fetched
    /// </summary>
    [JsonIgnore]
    public required long DurationMs { get; set; }

    /// <summary>
    /// EndMs is an optional param. It will default to the current time.
    /// </summary>
    [JsonIgnore]
    public long? EndMs { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
