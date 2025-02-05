using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record EquipmentStatsGps
{
    [JsonPropertyName("address")]
    public AddressTinyResponse? Address { get; set; }

    [JsonPropertyName("headingDegrees")]
    public double? HeadingDegrees { get; set; }

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

    [JsonPropertyName("reverseGeo")]
    public ReverseGeo? ReverseGeo { get; set; }

    [JsonPropertyName("speedMilesPerHour")]
    public double? SpeedMilesPerHour { get; set; }

    [JsonPropertyName("time")]
    public required string Time { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
