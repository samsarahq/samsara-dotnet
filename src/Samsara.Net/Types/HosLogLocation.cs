using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record HosLogLocation
{
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

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
