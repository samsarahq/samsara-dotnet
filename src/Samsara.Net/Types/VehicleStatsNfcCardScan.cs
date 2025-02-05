using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record VehicleStatsNfcCardScan
{
    [JsonPropertyName("card")]
    public required VehicleStatsNfcCardScanCard Card { get; set; }

    [JsonPropertyName("time")]
    public required string Time { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
