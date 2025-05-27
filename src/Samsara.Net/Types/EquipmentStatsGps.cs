using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// GPS location of equipment.
/// </summary>
public record EquipmentStatsGps
{
    [JsonPropertyName("address")]
    public AddressTinyResponse? Address { get; set; }

    [JsonPropertyName("headingDegrees")]
    public double? HeadingDegrees { get; set; }

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

    [JsonPropertyName("reverseGeo")]
    public ReverseGeo? ReverseGeo { get; set; }

    [JsonPropertyName("speedMilesPerHour")]
    public double? SpeedMilesPerHour { get; set; }

    [JsonPropertyName("time")]
    public required string Time { get; set; }

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
