using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record TachographDriverFileListWrapper
{
    [JsonPropertyName("driver")]
    public DriverTinyResponse? Driver { get; set; }

    [JsonPropertyName("files")]
    public IEnumerable<TachographDriverFile>? Files { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
