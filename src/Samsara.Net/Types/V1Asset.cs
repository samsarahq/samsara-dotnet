using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1Asset
{
    /// <summary>
    /// Serial number of the host asset
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
    /// Asset name
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The ID of the Vehicle associated to the Asset (if present)
    /// </summary>
    [JsonPropertyName("vehicleId")]
    public long? VehicleId { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
