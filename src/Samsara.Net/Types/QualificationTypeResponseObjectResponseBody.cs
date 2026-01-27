using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Qualification type response object.
/// </summary>
[Serializable]
public record QualificationTypeResponseObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Creation time of the qualification type. UTC timestamp in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("createdAtTime")]
    public required DateTime CreatedAtTime { get; set; }

    [JsonPropertyName("createdBy")]
    public required FormsPolymorphicUserObjectResponseBody CreatedBy { get; set; }

    /// <summary>
    /// Owner entity type  Valid values: `worker`, `asset`
    /// </summary>
    [JsonPropertyName("entityType")]
    public required QualificationTypeResponseObjectResponseBodyEntityType EntityType { get; set; }

    /// <summary>
    /// List of fields in the qualification type.
    /// </summary>
    [JsonPropertyName("fields")]
    public IEnumerable<FormsFieldDefinitionObjectResponseBody> Fields { get; set; } =
        new List<FormsFieldDefinitionObjectResponseBody>();

    /// <summary>
    /// Unique identifier of the qualification type.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Name of the qualification type.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Unique identifier of the qualification type revision.
    /// </summary>
    [JsonPropertyName("revisionId")]
    public required string RevisionId { get; set; }

    /// <summary>
    /// Update time of the qualification type. UTC timestamp in RFC 3339 format.
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
