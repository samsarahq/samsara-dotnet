using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record VehicleStatsSpreaderOnState
{
    [JsonPropertyName("time")]
    public required string Time { get; set; }

    /// <summary>
    /// Whether vehicle spreader is enabled.
    /// </summary>
    [JsonPropertyName("value")]
    public required VehicleStatsSpreaderOnStateValue Value { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
