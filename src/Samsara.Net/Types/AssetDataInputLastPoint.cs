using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record AssetDataInputLastPoint
{
    [JsonPropertyName("time")]
    public string? Time { get; set; }

    /// <summary>
    /// Numeric value of the data point.
    /// </summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
