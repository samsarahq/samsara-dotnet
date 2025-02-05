using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

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

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
