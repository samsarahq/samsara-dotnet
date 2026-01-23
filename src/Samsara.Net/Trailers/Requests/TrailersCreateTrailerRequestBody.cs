using System.Text.Json.Serialization;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.Trailers;

[Serializable]
public record TrailersCreateTrailerRequestBody
{
    /// <summary>
    /// A list of attributes to assign to the trailer.
    /// </summary>
    [JsonPropertyName("attributes")]
    public IEnumerable<GoaAttributeTinyRequestBody>? Attributes { get; set; }

    /// <summary>
    /// Indicates if the trailer is visible on the Samsara mobile apps.
    /// </summary>
    [JsonPropertyName("enabledForMobile")]
    public bool? EnabledForMobile { get; set; }

    /// <summary>
    /// A map of external ids
    /// </summary>
    [JsonPropertyName("externalIds")]
    public Dictionary<string, string>? ExternalIds { get; set; }

    /// <summary>
    /// The license plate of the Trailer. **By default**: empty. Can be set or updated through the Samsara Dashboard or the API at any time.
    /// </summary>
    [JsonPropertyName("licensePlate")]
    public string? LicensePlate { get; set; }

    /// <summary>
    /// The human-readable name of the Trailer. This is set by a fleet administrator and will appear in both Samsara’s cloud dashboard as well as the Samsara Driver mobile app. By default, this name is the serial number of the Samsara Asset Gateway. It can be set or updated through the Samsara Dashboard or through the API at any time.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// These are generic notes about the Trailer. Empty by default. Can be set or updated through the Samsara Dashboard or the API at any time.
    /// </summary>
    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    /// <summary>
    /// An array of IDs of tags to associate with this trailer. If your access to the API is scoped by one or more tags, this field is required to pass in.
    /// </summary>
    [JsonPropertyName("tagIds")]
    public IEnumerable<string>? TagIds { get; set; }

    /// <summary>
    /// The serial number of the trailer.
    /// </summary>
    [JsonPropertyName("trailerSerialNumber")]
    public string? TrailerSerialNumber { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
