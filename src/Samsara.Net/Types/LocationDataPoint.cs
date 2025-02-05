using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record LocationDataPoint
{
    [JsonPropertyName("gpsLocation")]
    public LocationDataPointGpsLocation? GpsLocation { get; set; }

    [JsonPropertyName("time")]
    public string? Time { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
