using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record IssuesPatchIssueResponseBody
{
    [JsonPropertyName("data")]
    public required IssueResponseObjectResponseBody Data { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
