using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Form Submission response object.
/// </summary>
public record FormSubmissionResponseObjectResponseBody
{
    [JsonPropertyName("approvalDetails")]
    public FormsProductSubmissionApprovalDetailsObjectResponseBody? ApprovalDetails { get; set; }

    [JsonPropertyName("asset")]
    public FormsAssetObjectResponseBody? Asset { get; set; }

    /// <summary>
    /// Assignment time of the form submission. Sometimes returned if the submission was assigned to a user or driver. UTC timestamp in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("assignedAtTime")]
    public DateTime? AssignedAtTime { get; set; }

    [JsonPropertyName("assignedTo")]
    public FormsPolymorphicUserObjectResponseBody? AssignedTo { get; set; }

    /// <summary>
    /// Creation time of the form submission. UTC timestamp in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("createdAtTime")]
    public required DateTime CreatedAtTime { get; set; }

    /// <summary>
    /// Time of when the submission is due. Sometimes returned, if the submission has a due date. UTC timestamp in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("dueAtTime")]
    public DateTime? DueAtTime { get; set; }

    /// <summary>
    /// A map of external ids
    /// </summary>
    [JsonPropertyName("externalIds")]
    public Dictionary<string, string>? ExternalIds { get; set; }

    /// <summary>
    /// List of field inputs in a form submission.
    /// </summary>
    [JsonPropertyName("fields")]
    public IEnumerable<FormsFieldInputObjectResponseBody> Fields { get; set; } =
        new List<FormsFieldInputObjectResponseBody>();

    [JsonPropertyName("formTemplate")]
    public required FormTemplateReferenceObjectResponseBody FormTemplate { get; set; }

    [JsonPropertyName("geofence")]
    public FormsGeofenceObjectResponseBody? Geofence { get; set; }

    /// <summary>
    /// ID of the form submission.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Indicates whether the worker is required to complete this form or not. Always returned.
    /// </summary>
    [JsonPropertyName("isRequired")]
    public required bool IsRequired { get; set; }

    [JsonPropertyName("location")]
    public FormsLocationObjectResponseBody? Location { get; set; }

    /// <summary>
    /// ID of the route. Sometimes returned if the submission was assigned to a route stop.
    /// </summary>
    [JsonPropertyName("routeId")]
    public string? RouteId { get; set; }

    /// <summary>
    /// ID of the route stop. Sometimes returned if the submission was assigned to a route stop.
    /// </summary>
    [JsonPropertyName("routeStopId")]
    public string? RouteStopId { get; set; }

    [JsonPropertyName("score")]
    public FormsScoreObjectResponseBody? Score { get; set; }

    /// <summary>
    /// State for the Form Submission. Always returned.  Valid values: `notStarted`, `completed`, `archived`, `inProgress`, `needsReview`, `changesRequested`, `approved`
    /// </summary>
    [JsonPropertyName("status")]
    public required FormSubmissionResponseObjectResponseBodyStatus Status { get; set; }

    /// <summary>
    /// Submission time of the form submission. UTC timestamp in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("submittedAtTime")]
    public required DateTime SubmittedAtTime { get; set; }

    [JsonPropertyName("submittedBy")]
    public required FormsPolymorphicUserObjectResponseBody SubmittedBy { get; set; }

    /// <summary>
    /// Title of the form submission. Sometimes returned if the submission has a title.
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>
    /// Update time of the form submission. UTC timestamp in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("updatedAtTime")]
    public required DateTime UpdatedAtTime { get; set; }

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
