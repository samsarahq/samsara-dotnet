using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Issue response object.
/// </summary>
[Serializable]
public record IssueResponseObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("asset")]
    public FormsAssetObjectResponseBody? Asset { get; set; }

    [JsonPropertyName("assignedTo")]
    public FormsPolymorphicUserObjectResponseBody? AssignedTo { get; set; }

    /// <summary>
    /// Creation time of the issue. UTC timestamp in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("createdAtTime")]
    public required DateTime CreatedAtTime { get; set; }

    /// <summary>
    /// Description of the issue. Included if the issue was given a description.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Due date of the issue. UTC timestamp in RFC 3339 format. Included if the issue was assigned a due date.
    /// </summary>
    [JsonPropertyName("dueDate")]
    public DateTime? DueDate { get; set; }

    /// <summary>
    /// A map of external ids
    /// </summary>
    [JsonPropertyName("externalIds")]
    public Dictionary<string, string>? ExternalIds { get; set; }

    /// <summary>
    /// ID of the issue.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("issueSource")]
    public required IssueSourceObjectResponseBody IssueSource { get; set; }

    /// <summary>
    /// List of media objects for the issue. Included if the issue has media.
    /// </summary>
    [JsonPropertyName("mediaList")]
    public IEnumerable<FormsMediaRecordObjectResponseBody>? MediaList { get; set; }

    /// <summary>
    /// Priority of the issue. Included if the issue was assigned a priority.  Valid values: `low`, `medium`, `high`
    /// </summary>
    [JsonPropertyName("priority")]
    public IssueResponseObjectResponseBodyPriority? Priority { get; set; }

    /// <summary>
    /// Status of the issue.  Valid values: `open`, `inProgress`, `resolved`, `dismissed`
    /// </summary>
    [JsonPropertyName("status")]
    public required IssueResponseObjectResponseBodyStatus Status { get; set; }

    /// <summary>
    /// Submission time of the issue. UTC timestamp in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("submittedAtTime")]
    public required DateTime SubmittedAtTime { get; set; }

    [JsonPropertyName("submittedBy")]
    public required FormsPolymorphicUserObjectResponseBody SubmittedBy { get; set; }

    /// <summary>
    /// Title of the issue.
    /// </summary>
    [JsonPropertyName("title")]
    public required string Title { get; set; }

    /// <summary>
    /// Update time of the issue. UTC timestamp in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("updatedAtTime")]
    public required DateTime UpdatedAtTime { get; set; }

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
