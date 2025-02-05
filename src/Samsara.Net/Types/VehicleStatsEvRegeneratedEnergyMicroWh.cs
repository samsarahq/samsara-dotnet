using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record VehicleStatsEvRegeneratedEnergyMicroWh
{
    [JsonPropertyName("time")]
    public required string Time { get; set; }

    /// <summary>
    /// Regenerated energy for electric and hybrid vehicles in microwatt hours.
    /// </summary>
    [JsonPropertyName("value")]
    public required long Value { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
