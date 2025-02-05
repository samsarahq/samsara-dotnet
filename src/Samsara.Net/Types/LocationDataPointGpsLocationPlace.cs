using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record LocationDataPointGpsLocationPlace
{
    /// <summary>
    /// City
    /// </summary>
    [JsonPropertyName("city")]
    public string? City { get; set; }

    /// <summary>
    /// House number
    /// </summary>
    [JsonPropertyName("houseNumber")]
    public string? HouseNumber { get; set; }

    /// <summary>
    /// Neighborhood
    /// </summary>
    [JsonPropertyName("neighborhood")]
    public string? Neighborhood { get; set; }

    /// <summary>
    /// POI
    /// </summary>
    [JsonPropertyName("poi")]
    public string? Poi { get; set; }

    /// <summary>
    /// Postcode
    /// </summary>
    [JsonPropertyName("postcode")]
    public string? Postcode { get; set; }

    /// <summary>
    /// State
    /// </summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>
    /// Street
    /// </summary>
    [JsonPropertyName("street")]
    public string? Street { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
