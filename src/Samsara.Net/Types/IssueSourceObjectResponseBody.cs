using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record IssueSourceObjectResponseBody
{
    /// <summary>
    /// ID of the issue's source object. The format depends on the 'type'. Included if 'type' is not 'ad-hoc'.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The type of issue source.  Valid values: `form`, `ad-hoc`
    /// </summary>
    [JsonPropertyName("type")]
    public required IssueSourceObjectResponseBodyType Type { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
