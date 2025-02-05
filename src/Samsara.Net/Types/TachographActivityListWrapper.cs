using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record TachographActivityListWrapper
{
    [JsonPropertyName("activity")]
    public IEnumerable<TachographActivity>? Activity { get; set; }

    [JsonPropertyName("driver")]
    public DriverTinyResponse? Driver { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
