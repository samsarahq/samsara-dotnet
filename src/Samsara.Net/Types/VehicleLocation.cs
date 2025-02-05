using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record VehicleLocation
{
    [JsonPropertyName("heading")]
    public double? Heading { get; set; }

    [JsonPropertyName("latitude")]
    public required double Latitude { get; set; }

    [JsonPropertyName("longitude")]
    public required double Longitude { get; set; }

    [JsonPropertyName("reverseGeo")]
    public ReverseGeo? ReverseGeo { get; set; }

    [JsonPropertyName("speed")]
    public double? Speed { get; set; }

    [JsonPropertyName("time")]
    public required string Time { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
