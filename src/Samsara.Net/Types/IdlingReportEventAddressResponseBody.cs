using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record IdlingReportEventAddressResponseBody
{
    /// <summary>
    /// The formatted address of the idling location.
    /// </summary>
    [JsonPropertyName("formatted")]
    public required string Formatted { get; set; }

    /// <summary>
    /// The latitude of the idling location.
    /// </summary>
    [JsonPropertyName("latitude")]
    public required double Latitude { get; set; }

    /// <summary>
    /// The longitude of the idling location.
    /// </summary>
    [JsonPropertyName("longitude")]
    public required double Longitude { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
