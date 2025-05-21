using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A single J1939D1 status
/// </summary>
public record J1939D1StatusDataPointValue
{
    [JsonPropertyName("amberLampStatus")]
    public int? AmberLampStatus { get; set; }

    [JsonPropertyName("fmi")]
    public int? Fmi { get; set; }

    [JsonPropertyName("milStatus")]
    public int? MilStatus { get; set; }

    [JsonPropertyName("occuranceCount")]
    public int? OccuranceCount { get; set; }

    [JsonPropertyName("protectLampStatus")]
    public int? ProtectLampStatus { get; set; }

    [JsonPropertyName("redLampStatus")]
    public int? RedLampStatus { get; set; }

    [JsonPropertyName("spn")]
    public int? Spn { get; set; }

    [JsonPropertyName("txId")]
    public int? TxId { get; set; }

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
