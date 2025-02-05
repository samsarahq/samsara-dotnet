using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record EquipmentObdEngineState
{
    [JsonPropertyName("time")]
    public required string Time { get; set; }

    /// <summary>
    /// The state of the engine read from on-board diagnostics. Valid values: `Off`, `On`, `Idle`.
    /// </summary>
    [JsonPropertyName("value")]
    public required EquipmentObdEngineStateValue Value { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
