using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Closest address that the GPS latitude and longitude match to.
/// </summary>
public record AddressResponseResponseBody
{
    /// <summary>
    /// The name of the city
    /// </summary>
    [JsonPropertyName("city")]
    public string? City { get; set; }

    /// <summary>
    /// The country
    /// </summary>
    [JsonPropertyName("country")]
    public string? Country { get; set; }

    /// <summary>
    /// The name of the neighborhood if one exists
    /// </summary>
    [JsonPropertyName("neighborhood")]
    public string? Neighborhood { get; set; }

    /// <summary>
    /// Point that may be of interest to the user
    /// </summary>
    [JsonPropertyName("pointOfInterest")]
    public string? PointOfInterest { get; set; }

    /// <summary>
    /// The zip code
    /// </summary>
    [JsonPropertyName("postalCode")]
    public string? PostalCode { get; set; }

    /// <summary>
    /// The name of the state
    /// </summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>
    /// The street name
    /// </summary>
    [JsonPropertyName("street")]
    public string? Street { get; set; }

    /// <summary>
    /// Street number of the address
    /// </summary>
    [JsonPropertyName("streetNumber")]
    public string? StreetNumber { get; set; }

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
