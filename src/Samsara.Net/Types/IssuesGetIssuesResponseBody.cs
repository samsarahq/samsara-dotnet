using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record IssuesGetIssuesResponseBody
{
    /// <summary>
    /// List of issues.
    /// </summary>
    [JsonPropertyName("data")]
    public IEnumerable<IssueResponseObjectResponseBody> Data { get; set; } =
        new List<IssueResponseObjectResponseBody>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
