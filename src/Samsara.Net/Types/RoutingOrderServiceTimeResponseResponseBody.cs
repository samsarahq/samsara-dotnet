using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Order service time configuration for a routing row.
/// </summary>
[Serializable]
public record RoutingOrderServiceTimeResponseResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("capacityServiceTime")]
    public RoutingCapacityServiceTimeResponseResponseBody? CapacityServiceTime { get; set; }

    /// <summary>
    /// Whether order service time settings apply at this stop.
    /// </summary>
    [JsonPropertyName("isEnabled")]
    public required bool IsEnabled { get; set; }

    /// <summary>
    /// Mode: unknown, unspecified, fixed, or variable.
    /// </summary>
    [JsonPropertyName("modeType")]
    public required string ModeType { get; set; }

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
