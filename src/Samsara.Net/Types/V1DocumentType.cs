using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1DocumentType
{
    /// <summary>
    /// The fields associated with this document type.
    /// </summary>
    [JsonPropertyName("fieldTypes")]
    public IEnumerable<V1DocumentFieldType> FieldTypes { get; set; } =
        new List<V1DocumentFieldType>();

    /// <summary>
    /// Name of the document type.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// ID for the organization this document belongs to.
    /// </summary>
    [JsonPropertyName("orgId")]
    public required long OrgId { get; set; }

    /// <summary>
    /// Universally unique identifier for the document type. Can be passed in as the `documentTypeUuid` when creating a document for this document type.
    /// </summary>
    [JsonPropertyName("uuid")]
    public required string Uuid { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
