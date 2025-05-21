using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Full assets inputs objects.
/// </summary>
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
