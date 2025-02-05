using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record LocationResponseBody
{
    /// <summary>
    /// Location latitude.
    /// </summary>
    [JsonPropertyName("Latitude")]
    public double? Latitude { get; set; }

    /// <summary>
    /// Location longitude.
    /// </summary>
    [JsonPropertyName("Longitude")]
    public double? Longitude { get; set; }

    /// <summary>
    /// Date time in RFC 3339 format. Millisecond precision and timezones are supported. (Examples: 2019-06-13T19:08:25Z, 2019-06-13T19:08:25.455Z, OR 2015-09-15T14:00:12-04:00).
    /// </summary>
    [JsonPropertyName("datetime")]
    public string? Datetime { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
