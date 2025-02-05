using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record VehicleStatsSpreaderActive
{
    [JsonPropertyName("time")]
    public required string Time { get; set; }

    /// <summary>
    /// Whether vehicle is actively spreading any material.
    /// </summary>
    [JsonPropertyName("value")]
    public required VehicleStatsSpreaderActiveValue Value { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
