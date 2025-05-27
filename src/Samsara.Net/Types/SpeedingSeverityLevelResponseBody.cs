using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// The settings for a specific speeding severity level.
/// </summary>
public record SpeedingSeverityLevelResponseBody
{
    /// <summary>
    /// The amount of time the vehicle is speeding in this category before being attributed to this level
    /// </summary>
    [JsonPropertyName("durationMs")]
    public required int DurationMs { get; set; }

    /// <summary>
    /// Indicates the severity level is enabled
    /// </summary>
    [JsonPropertyName("isEnabled")]
    public required bool IsEnabled { get; set; }

    /// <summary>
    /// The severity level name.  Valid values: `light`, `moderate`, `heavy`, `severe`
    /// </summary>
    [JsonPropertyName("severityLevel")]
    public required SpeedingSeverityLevelResponseBodySeverityLevel SeverityLevel { get; set; }

    /// <summary>
    /// The minimum speed above the speed limit that will get attributed to this severity level.
    /// </summary>
    [JsonPropertyName("speedOverLimitThreshold")]
    public required float SpeedOverLimitThreshold { get; set; }

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
