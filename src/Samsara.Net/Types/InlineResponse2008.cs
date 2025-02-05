using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record InlineResponse2008
{
    [JsonPropertyName("machines")]
    public IEnumerable<V1Machine>? Machines { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
