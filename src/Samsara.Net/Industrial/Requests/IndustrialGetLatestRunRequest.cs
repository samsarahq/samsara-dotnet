using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Industrial;

public record IndustrialGetLatestRunRequest
{
    /// <summary>
    /// The configured program's ID on the camera.
    /// </summary>
    [JsonIgnore]
    public long? ProgramId { get; set; }

    /// <summary>
    /// EndMs is an optional param. It will default to the current time.
    /// </summary>
    [JsonIgnore]
    public long? StartedAtMs { get; set; }

    /// <summary>
    /// Include is a filter parameter. Accepts 'pass', 'reject' or 'no_read'.
    /// </summary>
    [JsonIgnore]
    public string? Include { get; set; }

    /// <summary>
    /// Limit is an integer value from 1 to 1,000.
    /// </summary>
    [JsonIgnore]
    public long? Limit { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
