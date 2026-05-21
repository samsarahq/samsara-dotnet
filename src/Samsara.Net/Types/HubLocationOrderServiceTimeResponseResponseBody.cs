using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Order service time configuration for a hub location.
/// </summary>
[Serializable]
public record HubLocationOrderServiceTimeResponseResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Capacity-based service times for variable mode.
    /// </summary>
    [JsonPropertyName("capacityServiceTimes")]
    public IEnumerable<HubLocationCapacityServiceTimeResponseResponseBody>? CapacityServiceTimes { get; set; }

    /// <summary>
    /// Fixed order service time in seconds when applicable.
    /// </summary>
    [JsonPropertyName("fixedTimeSeconds")]
    public long? FixedTimeSeconds { get; set; }

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
