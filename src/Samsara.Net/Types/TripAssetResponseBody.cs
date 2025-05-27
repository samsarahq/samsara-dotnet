using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Asset that the location readings are tied to
/// </summary>
public record TripAssetResponseBody
{
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

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
