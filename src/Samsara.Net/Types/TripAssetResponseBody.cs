using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Asset that the location readings are tied to
/// </summary>
[Serializable]
public record TripAssetResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Unique ID for the asset object that is reporting the location.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Name for the asset object that is reporting the location. Only returns when `includeAsset` is set to `true`.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Type for the asset object that is reporting the location. Only returns when `includeAsset` is set to `true`.  Valid values: `uncategorized`, `trailer`, `equipment`, `unpowered`, `vehicle`
    /// </summary>
    [JsonPropertyName("type")]
    public TripAssetResponseBodyType? Type { get; set; }

    /// <summary>
    /// VIN for the asset object that is reporting the location. Only returns when `includeAsset` is set to `true`.
    /// </summary>
    [JsonPropertyName("vin")]
    public string? Vin { get; set; }

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
