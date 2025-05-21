using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Basic information of an asset
/// </summary>
public record V1AssetCurrentLocationsResponse
{
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
    public int? EngineHours { get; set; }

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
