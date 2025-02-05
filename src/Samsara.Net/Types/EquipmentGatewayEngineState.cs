using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record EquipmentGatewayEngineState
{
    [JsonPropertyName("time")]
    public required string Time { get; set; }

    /// <summary>
    /// An approximation of engine state based on readings the AG26 receives from the aux/digio cable. Valid values: `Off`, `On`.
    /// </summary>
    [JsonPropertyName("value")]
    public required EquipmentGatewayEngineStateValue Value { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
