using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record FuelRemainingResponseBody
{
    /// <summary>
    /// Percent of fuel remaining in tank.
    /// </summary>
    [JsonPropertyName("Percent")]
    public double? Percent { get; set; }

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
