using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Current location of an asset
/// </summary>
public record V1AssetCurrentLocation
{
    /// <summary>
    /// The latitude of the location in degrees.
    /// </summary>
    [JsonPropertyName("latitude")]
    public double? Latitude { get; set; }

    /// <summary>
    /// The best effort (street,city,state) for the latitude and longitude.
    /// </summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// The longitude of the location in degrees.
    /// </summary>
    [JsonPropertyName("longitude")]
    public double? Longitude { get; set; }

    /// <summary>
    /// The speed calculated from GPS that the asset was traveling at in miles per hour.
    /// </summary>
    [JsonPropertyName("speedMilesPerHour")]
    public double? SpeedMilesPerHour { get; set; }

    /// <summary>
    /// Time in Unix milliseconds since epoch when the asset was at the location.
    /// </summary>
    [JsonPropertyName("timeMs")]
    public double? TimeMs { get; set; }

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
