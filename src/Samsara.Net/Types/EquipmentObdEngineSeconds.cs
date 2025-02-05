using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record EquipmentObdEngineSeconds
{
    [JsonPropertyName("time")]
    public required string Time { get; set; }

    /// <summary>
    /// The number of seconds the engine has been running since it was new. This value is provided directly from on-board diagnostics.
    /// </summary>
    [JsonPropertyName("value")]
    public required int Value { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
