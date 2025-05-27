using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Prewet spread rate reading in milliliters per meter, read from the material spreader. Unfiltered live stats are supplied as-read from the Material Spreader unit. Readings do not consider total spread rate(s) over time or distance. Unfiltered live stats are supplied as-read from the Material Spreader unit. Readings do not consider total spread rate(s) over time or distance.
/// </summary>
public record VehicleStatsResponseSpreaderPrewetRate
{
    /// <summary>
    /// UTC timestamp in RFC 3339 format. Example: `2020-01-27T07:06:25Z`.
    /// </summary>
    [JsonPropertyName("time")]
    public required string Time { get; set; }

    /// <summary>
    /// Prewet spread rate reading in milliliters per meter, read from the material spreader. Unfiltered live stats are supplied as-read from the Material Spreader unit. Readings do not consider total spread rate(s) over time or distance. Unfiltered live stats are supplied as-read from the Material Spreader unit. Readings do not consider total spread rate(s) over time or distance.
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
