using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Basic information of an asset
/// </summary>
[Serializable]
public record V1AssetCurrentLocationsResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Asset serial number
    /// </summary>
    [JsonPropertyName("assetSerialNumber")]
    public string? AssetSerialNumber { get; set; }

    [JsonPropertyName("cable")]
    public V1AssetCable? Cable { get; set; }

    /// <summary>
    /// Engine hours
    /// </summary>
    [JsonPropertyName("engineHours")]
    public long? EngineHours { get; set; }

    /// <summary>
    /// Asset ID
    /// </summary>
    [JsonPropertyName("id")]
    public required long Id { get; set; }

    /// <summary>
    /// Current location of an asset
    /// </summary>
    [JsonPropertyName("location")]
    public IEnumerable<V1AssetCurrentLocation>? Location { get; set; }

    /// <summary>
    /// Asset name
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

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
