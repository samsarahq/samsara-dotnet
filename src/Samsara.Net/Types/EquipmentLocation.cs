using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record EquipmentLocation
{
    /// <summary>
    /// Heading of the unit of equipment in degrees.
    /// </summary>
    [JsonPropertyName("heading")]
    public double? Heading { get; set; }

    /// <summary>
    /// GPS latitude represented in degrees
    /// </summary>
    [JsonPropertyName("latitude")]
    public required double Latitude { get; set; }

    /// <summary>
    /// GPS longitude represented in degrees
    /// </summary>
    [JsonPropertyName("longitude")]
    public required double Longitude { get; set; }

    /// <summary>
    /// GPS speed of the unit of equipment in miles per hour.
    /// </summary>
    [JsonPropertyName("speed")]
    public double? Speed { get; set; }

    [JsonPropertyName("time")]
    public required string Time { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
