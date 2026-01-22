using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// [DEPRECATED] Please use either `gatewayEngineSeconds` or `obdEngineSeconds`.
/// </summary>
[Serializable]
public record EquipmentEngineSeconds : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("time")]
    public required string Time { get; set; }

    /// <summary>
    /// An approximation of the number of seconds the engine has been running since it was new, based on the amount of time the AG26 device is receiving power and an offset provided manually through the Samsara cloud dashboard.
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
