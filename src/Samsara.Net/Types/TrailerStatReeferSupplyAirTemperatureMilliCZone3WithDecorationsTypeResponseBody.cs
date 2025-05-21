using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Supply or discharge air temperature of zone 2 of the reefer. This is the temperature of the air as it leaves the cooling unit.
/// </summary>
public record TrailerStatReeferSupplyAirTemperatureMilliCZone3WithDecorationsTypeResponseBody
{
    [JsonPropertyName("decorations")]
    public TrailerStatDecorationResponseBody? Decorations { get; set; }

    /// <summary>
    /// UTC timestamp in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("time")]
    public required string Time { get; set; }

    /// <summary>
    /// The supply or discharge air temperature reading in millidegree Celsius.
    /// </summary>
    [JsonPropertyName("value")]
    public required long Value { get; set; }

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
