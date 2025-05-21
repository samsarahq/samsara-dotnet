using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Address of the location
/// </summary>
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

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
