using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record VehicleStatsDecorationsGps
{
    [JsonPropertyName("address")]
    public VehicleLocationAddress? Address { get; set; }

    [JsonPropertyName("headingDegrees")]
    public double? HeadingDegrees { get; set; }

    [JsonPropertyName("isEcuSpeed")]
    public bool? IsEcuSpeed { get; set; }

    [JsonPropertyName("latitude")]
    public required double Latitude { get; set; }

    [JsonPropertyName("longitude")]
    public required double Longitude { get; set; }

    [JsonPropertyName("reverseGeo")]
    public ReverseGeo? ReverseGeo { get; set; }

    [JsonPropertyName("speedMilesPerHour")]
    public double? SpeedMilesPerHour { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
