using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1HumidityResponse
{
    /// <summary>
    /// Deprecated.
    /// </summary>
    [JsonPropertyName("groupId")]
    public long? GroupId { get; set; }

    [JsonPropertyName("sensors")]
    public IEnumerable<V1HumidityResponseSensors>? Sensors { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
