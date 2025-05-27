using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Tachograph activity
/// </summary>
public record TachographActivity
{
    /// <summary>
    /// End time of state in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>
    /// A flag indicating whether the activity was manually entered by the driver. If this is `true`, the state cannot be "UNKNOWN"
    /// </summary>
    [JsonPropertyName("isManualEntry")]
    public bool? IsManualEntry { get; set; }

    /// <summary>
    /// Start time of state in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>
    /// Tachograph activity state. Valid values: `BREAK/REST`, `WORK`, `AVAILABILITY`, `DRIVING`, `UNKNOWN`.
    /// </summary>
    [JsonPropertyName("state")]
    public TachographActivityState? State { get; set; }

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
