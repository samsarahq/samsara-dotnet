using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record EquipmentEngineRpm
{
    [JsonPropertyName("time")]
    public required string Time { get; set; }

    /// <summary>
    /// The revolutions per minute of the engine.
    /// </summary>
    [JsonPropertyName("value")]
    public required int Value { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
