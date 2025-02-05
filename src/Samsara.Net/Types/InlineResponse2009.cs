using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record InlineResponse2009
{
    [JsonPropertyName("sensors")]
    public IEnumerable<V1Sensor>? Sensors { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
