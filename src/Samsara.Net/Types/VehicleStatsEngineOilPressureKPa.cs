using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record VehicleStatsEngineOilPressureKPa
{
    [JsonPropertyName("time")]
    public required string Time { get; set; }

    /// <summary>
    /// The engine oil pressure reading in kilopascals.
    /// </summary>
    [JsonPropertyName("value")]
    public required long Value { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
