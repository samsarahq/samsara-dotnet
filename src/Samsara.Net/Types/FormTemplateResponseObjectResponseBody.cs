using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Form Template response object.
/// </summary>
public record FormTemplateResponseObjectResponseBody
{
    [JsonPropertyName("approvalConfig")]
    public FormsApprovalConfigObjectResponseBody? ApprovalConfig { get; set; }

    /// <summary>
    /// Creation time of the form template. UTC timestamp in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("createdAtTime")]
    public required DateTime CreatedAtTime { get; set; }

    [JsonPropertyName("createdBy")]
    public required FormsPolymorphicUserObjectResponseBody CreatedBy { get; set; }

    /// <summary>
    /// Description of the form template.
    /// </summary>
    [JsonPropertyName("description")]
    public required string Description { get; set; }

    /// <summary>
    /// List of fields in the form template.
    /// </summary>
    [JsonPropertyName("fields")]
    public IEnumerable<FormsFieldDefinitionObjectResponseBody> Fields { get; set; } =
        new List<FormsFieldDefinitionObjectResponseBody>();

    /// <summary>
    /// Unique identifier of the form template.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Unique identifier of the form template revision.
    /// </summary>
    [JsonPropertyName("revisionId")]
    public required string RevisionId { get; set; }

    /// <summary>
    /// List of sections in the form template.
    /// </summary>
    [JsonPropertyName("sections")]
    public IEnumerable<FormTemplateSectionObjectResponseBody> Sections { get; set; } =
        new List<FormTemplateSectionObjectResponseBody>();

    /// <summary>
    /// Title of the form template.
    /// </summary>
    [JsonPropertyName("title")]
    public required string Title { get; set; }

    /// <summary>
    /// Update time of the form template. UTC timestamp in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("updatedAtTime")]
    public required DateTime UpdatedAtTime { get; set; }

    [JsonPropertyName("updatedBy")]
    public required FormsPolymorphicUserObjectResponseBody UpdatedBy { get; set; }

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
