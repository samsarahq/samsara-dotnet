using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record VehicleStatsDecorationsEngineStates
{
    /// <summary>
    /// The state of the engine.
    /// </summary>
    [JsonPropertyName("value")]
    public required VehicleStatsDecorationsEngineStatesValue Value { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
