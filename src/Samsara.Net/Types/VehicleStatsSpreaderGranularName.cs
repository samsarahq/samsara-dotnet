using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record VehicleStatsSpreaderGranularName
{
    [JsonPropertyName("time")]
    public required string Time { get; set; }

    /// <summary>
    /// Name of most recent type of granular material spread, read from the material spreader.
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
