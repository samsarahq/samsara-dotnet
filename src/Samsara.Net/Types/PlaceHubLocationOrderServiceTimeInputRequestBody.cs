using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Order service time configuration for a hub location row.
/// </summary>
[Serializable]
public record PlaceHubLocationOrderServiceTimeInputRequestBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Capacity-based service times for variable mode.
    /// </summary>
    [JsonPropertyName("capacityServiceTimes")]
    public IEnumerable<PlaceHubLocationCapacityServiceTimeInputRequestBody>? CapacityServiceTimes { get; set; }

    /// <summary>
    /// Fixed order service time in seconds when applicable.
    /// </summary>
    [JsonPropertyName("fixedTimeSeconds")]
    public long? FixedTimeSeconds { get; set; }

    /// <summary>
    /// Mode: fixed or variable.  Valid values: `fixed`, `variable`, `unknown`, `unspecified`
    /// </summary>
    [JsonPropertyName("modeType")]
    public required PlaceHubLocationOrderServiceTimeInputRequestBodyModeType ModeType { get; set; }

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
