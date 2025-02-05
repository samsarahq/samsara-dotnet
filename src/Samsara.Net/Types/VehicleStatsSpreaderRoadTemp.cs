using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record VehicleStatsSpreaderRoadTemp
{
    [JsonPropertyName("time")]
    public required string Time { get; set; }

    /// <summary>
    /// Road temperature reading in milli celsius from material spreader.
    /// </summary>
    [JsonPropertyName("value")]
    public required long Value { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
