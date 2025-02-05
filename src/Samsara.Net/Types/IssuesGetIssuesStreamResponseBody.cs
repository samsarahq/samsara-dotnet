using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record IssuesGetIssuesStreamResponseBody
{
    /// <summary>
    /// List of issues.
    /// </summary>
    [JsonPropertyName("data")]
    public IEnumerable<IssueResponseObjectResponseBody> Data { get; set; } =
        new List<IssueResponseObjectResponseBody>();

    [JsonPropertyName("pagination")]
    public required GoaPaginationResponseResponseBody Pagination { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
