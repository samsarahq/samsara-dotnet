using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Engine seconds reading from the J1939/CAT cable.
/// </summary>
[Serializable]
public record EquipmentGatewayJ1939EngineSeconds : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("time")]
    public required string Time { get; set; }

    /// <summary>
    /// The number of seconds an engine has been running as detected via aux input 1 active state. Used in combination with an offset provided manually through the Samsara cloud dashboard. This is supported with the following hardware configurations: AG24/AG26/AG46P + APWR cable (Auxiliary engine configuration required) AG52/AG53 + BPWR/BEQP cable (Auxiliary engine configuration required).
    /// </summary>
    [JsonPropertyName("value")]
    public required long Value { get; set; }

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
