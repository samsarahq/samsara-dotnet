using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Details for stop ETA updated events.
/// </summary>
[Serializable]
public record StopEtaUpdatedEventDetailsResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Estimated arrival time in milliseconds since epoch.
    /// </summary>
    [JsonPropertyName("etaMs")]
    public required string EtaMs { get; set; }

    /// <summary>
    /// Time when the ETA was updated in milliseconds since epoch.
    /// </summary>
    [JsonPropertyName("etaUpdatedAtMs")]
    public required string EtaUpdatedAtMs { get; set; }

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
