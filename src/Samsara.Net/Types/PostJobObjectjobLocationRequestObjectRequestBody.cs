using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record PostJobObjectjobLocationRequestObjectRequestBody
{
    /// <summary>
    /// Address of a location
    /// </summary>
    [JsonPropertyName("address")]
    public required string Address { get; set; }

    /// <summary>
    /// Latitude of a location
    /// </summary>
    [JsonPropertyName("latitude")]
    public required double Latitude { get; set; }

    /// <summary>
    /// Longitude of a location
    /// </summary>
    [JsonPropertyName("longitude")]
    public required double Longitude { get; set; }

    /// <summary>
    /// Name of the location
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
