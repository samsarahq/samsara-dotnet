using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Qualification Record response object.
/// </summary>
[Serializable]
public record QualificationRecordResponseObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Creation time. UTC timestamp in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("createdAtTime")]
    public required DateTime CreatedAtTime { get; set; }

    [JsonPropertyName("createdBy")]
    public required FormsPolymorphicUserObjectResponseBody CreatedBy { get; set; }

    /// <summary>
    /// Expiration date. UTC timestamp in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("expirationDate")]
    public DateTime? ExpirationDate { get; set; }

    /// <summary>
    /// A map of external ids
    /// </summary>
    [JsonPropertyName("externalIds")]
    public Dictionary<string, string>? ExternalIds { get; set; }

    /// <summary>
    /// List of field inputs in a qualification record.
    /// </summary>
    [JsonPropertyName("fields")]
    public IEnumerable<QualificationFieldInputObjectResponseBody> Fields { get; set; } =
        new List<QualificationFieldInputObjectResponseBody>();

    /// <summary>
    /// ID of the qualification record.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Issue/effective date. UTC timestamp in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("issueDate")]
    public required DateTime IssueDate { get; set; }

    [JsonPropertyName("owner")]
    public required QualificationOwnerObjectResponseBody Owner { get; set; }

    [JsonPropertyName("qualificationType")]
    public required QualificationTypeReferenceObjectResponseBody QualificationType { get; set; }

    /// <summary>
    /// Status of the qualification record.  Valid values: `active`, `archived`, `deleted`
    /// </summary>
    [JsonPropertyName("recordStatus")]
    public required QualificationRecordResponseObjectResponseBodyRecordStatus RecordStatus { get; set; }

    /// <summary>
    /// Last updated time. UTC timestamp in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("updatedAtTime")]
    public required DateTime UpdatedAtTime { get; set; }

    [JsonPropertyName("updatedBy")]
    public required FormsPolymorphicUserObjectResponseBody UpdatedBy { get; set; }

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
