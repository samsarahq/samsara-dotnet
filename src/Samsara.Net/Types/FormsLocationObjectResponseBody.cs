using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record FormsLocationObjectResponseBody
{
    /// <summary>
    /// Latitude of a location.
    /// </summary>
    [JsonPropertyName("latitude")]
    public required double Latitude { get; set; }

    /// <summary>
    /// Longitude of a location.
    /// </summary>
    [JsonPropertyName("longitude")]
    public required double Longitude { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
