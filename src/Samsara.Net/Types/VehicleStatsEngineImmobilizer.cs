using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record VehicleStatsEngineImmobilizer
{
    /// <summary>
    /// Whether the engine immobilizer is connected or not
    /// </summary>
    [JsonPropertyName("connected")]
    public required bool Connected { get; set; }

    /// <summary>
    /// The state of the engine immobilizer. Valid values: `ignition_disabled`, `ignition_enabled`. This stat type will only return states of our first Engine Immobilizer Hardware (ACC-EI). Please use &lt;a href="https://developers.samsara.com/reference/getengineimmobilizerstates" target="_blank"&gt;Get engine immobilizer states&lt;/a&gt; to get states for both Engine Immobilizer Hardware versions (incl. HW-EI21).
    /// </summary>
    [JsonPropertyName("state")]
    public required VehicleStatsEngineImmobilizerState State { get; set; }

    [JsonPropertyName("time")]
    public required string Time { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
