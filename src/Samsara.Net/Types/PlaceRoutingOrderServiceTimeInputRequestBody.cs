using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Order service time configuration for a routing row.
/// </summary>
[Serializable]
public record PlaceRoutingOrderServiceTimeInputRequestBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("capacityServiceTime")]
    public PlaceRoutingCapacityServiceTimeInputRequestBody? CapacityServiceTime { get; set; }

    /// <summary>
    /// Fixed order service time in seconds. Required when modeType is fixed.
    /// </summary>
    [JsonPropertyName("fixedServiceTimeSeconds")]
    public long? FixedServiceTimeSeconds { get; set; }

    /// <summary>
    /// When true, order service time settings apply at this stop; when false, hub/session defaults apply.
    /// </summary>
    [JsonPropertyName("isEnabled")]
    public bool? IsEnabled { get; set; }

    /// <summary>
    /// Mode: fixed or variable.  Valid values: `fixed`, `variable`
    /// </summary>
    [JsonPropertyName("modeType")]
    public required PlaceRoutingOrderServiceTimeInputRequestBodyModeType ModeType { get; set; }

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
