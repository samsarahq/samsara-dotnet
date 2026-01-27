using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// The settings for a specific speeding severity level.
/// </summary>
[Serializable]
public record SpeedingSeverityLevelResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

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

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
