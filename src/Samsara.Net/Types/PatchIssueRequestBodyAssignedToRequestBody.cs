using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record PatchIssueRequestBodyAssignedToRequestBody
{
    /// <summary>
    /// ID of the issue assignee.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Type of the issue assignee.  Valid values: `user`
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
