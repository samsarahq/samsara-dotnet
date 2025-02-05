using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record AssetsInputsResponseResponseBody
{
    [JsonPropertyName("asset")]
    public required AssetsInputsAssetResponseResponseBody Asset { get; set; }

    [JsonPropertyName("auxInput")]
    public AssetsInputsAuxInputResponseBody? AuxInput { get; set; }

    /// <summary>
    /// UTC timestamp in RFC 3339 format of the event.
    /// </summary>
    [JsonPropertyName("happenedAtTime")]
    public required string HappenedAtTime { get; set; }

    /// <summary>
    /// Units of the values in the returned data.  Valid values: `boolean`, `millivolts`, `microamps`
    /// </summary>
    [JsonPropertyName("units")]
    public required AssetsInputsResponseResponseBodyUnits Units { get; set; }

    /// <summary>
    /// Value of the data point.
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
