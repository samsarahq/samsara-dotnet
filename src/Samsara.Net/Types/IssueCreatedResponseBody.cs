using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record IssueCreatedResponseBody
{
    [JsonPropertyName("issue")]
    public required IssueResponseObjectResponseBody Issue { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
