using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Remaining durations and start time for the HOS driving cycle.
/// </summary>
[Serializable]
public record HosCycle : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Remaining on duty or driving time the driver has in the current cycle in milliseconds. For property-carrying drivers, this is the amount of time the driver can be on duty or driving before hitting the 60/70-hour limit in 7/8 days.
    /// </summary>
    [JsonPropertyName("cycleRemainingDurationMs")]
    public double? CycleRemainingDurationMs { get; set; }

    [JsonPropertyName("cycleStartedAtTime")]
    public string? CycleStartedAtTime { get; set; }

    /// <summary>
    /// Remaining on duty or driving time the driver has available tomorrow in milliseconds. For property-carrying drivers this is calculated based on the 60/70-hour limit in 7/8 days rule.
    /// </summary>
    [JsonPropertyName("cycleTomorrowDurationMs")]
    public double? CycleTomorrowDurationMs { get; set; }

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
