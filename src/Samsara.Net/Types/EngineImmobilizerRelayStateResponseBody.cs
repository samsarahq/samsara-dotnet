using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// An engine immobilizer relay state.
/// </summary>
[Serializable]
public record EngineImmobilizerRelayStateResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The ID of the relay  Valid values: `relay1`, `relay2`
    /// </summary>
    [JsonPropertyName("id")]
    public required EngineImmobilizerRelayStateResponseBodyId Id { get; set; }

    /// <summary>
    /// Whether the relay is open.
    /// </summary>
    [JsonPropertyName("isOpen")]
    public required bool IsOpen { get; set; }

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
