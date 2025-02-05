using System.Text.Json.Serialization;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.Beta;

public record IssuesPatchIssueRequestBody
{
    [JsonPropertyName("assignedTo")]
    public PatchIssueRequestBodyAssignedToRequestBody? AssignedTo { get; set; }

    /// <summary>
    /// Due date of the issue. UTC timestamp in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("dueDate")]
    public DateTime? DueDate { get; set; }

    /// <summary>
    /// A map of external ids
    /// </summary>
    [JsonPropertyName("externalIds")]
    public Dictionary<string, string>? ExternalIds { get; set; }

    /// <summary>
    /// ID of the issue. Can be either a unique Samsara ID or an [external ID](https://developers.samsara.com/docs/external-ids) for the issue.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Status of the issue.  Valid values: `open`, `inProgress`, `resolved`, `dismissed`
    /// </summary>
    [JsonPropertyName("status")]
    public IssuesPatchIssueRequestBodyStatus? Status { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
