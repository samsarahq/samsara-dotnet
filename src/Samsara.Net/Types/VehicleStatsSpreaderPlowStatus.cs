using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record VehicleStatsSpreaderPlowStatus
{
    [JsonPropertyName("time")]
    public required string Time { get; set; }

    /// <summary>
    /// Snow plow status, as read from the material spreader
    /// </summary>
    [JsonPropertyName("value")]
    public required VehicleStatsSpreaderPlowStatusValue Value { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
