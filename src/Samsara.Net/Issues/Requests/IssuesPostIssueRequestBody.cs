using System.Text.Json.Serialization;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.Issues;

[Serializable]
public record IssuesPostIssueRequestBody
{
    [JsonPropertyName("asset")]
    public required PostIssueRequestBodyAssetRequestBody Asset { get; set; }

    [JsonPropertyName("assignedTo")]
    public PostIssueRequestBodyAssignedToRequestBody? AssignedTo { get; set; }

    /// <summary>
    /// Description of the issue.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

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
    /// Media items to attach to the issue.
    /// </summary>
    [JsonPropertyName("media")]
    public IEnumerable<FormSubmissionRequestMediaItemObjectRequestBody>? Media { get; set; }

    /// <summary>
    /// Priority of the issue.  Valid values: `low`, `medium`, `high`
    /// </summary>
    [JsonPropertyName("priority")]
    public IssuesPostIssueRequestBodyPriority? Priority { get; set; }

    /// <summary>
    /// Status of the issue. Defaults to `open` when omitted.  Valid values: `open`, `inProgress`, `resolved`, `dismissed`
    /// </summary>
    [JsonPropertyName("status")]
    public IssuesPostIssueRequestBodyStatus? Status { get; set; }

    /// <summary>
    /// Title of the issue.
    /// </summary>
    [JsonPropertyName("title")]
    public required string Title { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
