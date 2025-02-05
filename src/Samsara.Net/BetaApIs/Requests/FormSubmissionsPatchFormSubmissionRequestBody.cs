using System.Text.Json.Serialization;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

public record FormSubmissionsPatchFormSubmissionRequestBody
{
    [JsonPropertyName("assignedTo")]
    public FormSubmissionRequestAssignedToRequestBody? AssignedTo { get; set; }

    /// <summary>
    /// Due date of the form submission. UTC timestamp in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("dueAtTime")]
    public DateTime? DueAtTime { get; set; }

    /// <summary>
    /// ID of the form submission.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Indicates whether the worker is required to complete this form or not at a specific route stop. Defaults to `true` if the form is assigned to a user or driver. When true, the worker cannot depart the route stop until this form submission is `submitted`.
    /// </summary>
    [JsonPropertyName("isRequired")]
    public bool? IsRequired { get; set; }

    /// <summary>
    /// ID of the route stop the form submission is assigned to. Must be a unique Samsara ID.
    /// </summary>
    [JsonPropertyName("routeStopId")]
    public string? RouteStopId { get; set; }

    /// <summary>
    /// Status of the form submission.  Valid values: `toDo`, `dismissed`
    /// </summary>
    [JsonPropertyName("status")]
    public FormSubmissionsPatchFormSubmissionRequestBodyStatus? Status { get; set; }

    /// <summary>
    /// Title of the form submission.
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
