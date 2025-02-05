using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

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

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
