using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record VehicleStatsAuxInput
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("time")]
    public string? Time { get; set; }

    /// <summary>
    /// Boolean indicating the state of the auxiliary equipment.
    /// </summary>
    [JsonPropertyName("value")]
    public bool? Value { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
