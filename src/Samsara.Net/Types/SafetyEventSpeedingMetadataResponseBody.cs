using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Speeding data associated with the event. Only returned for speeding related events.
/// </summary>
[Serializable]
public record SafetyEventSpeedingMetadataResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The max speed exceeded during the event, provided in kilometers per hour.
    /// </summary>
    [JsonPropertyName("maxSpeedKilometersPerHour")]
    public required long MaxSpeedKilometersPerHour { get; set; }

    /// <summary>
    /// The posted speed limit associated with the event, provided in kilometers per hour.
    /// </summary>
    [JsonPropertyName("postedSpeedLimitKilometersPerHour")]
    public required long PostedSpeedLimitKilometersPerHour { get; set; }

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
