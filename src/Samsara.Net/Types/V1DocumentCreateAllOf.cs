using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1DocumentCreateAllOf
{
    /// <summary>
    /// Universally unique identifier for the document type that this document is being created for.
    /// </summary>
    [JsonPropertyName("documentTypeUuid")]
    public required string DocumentTypeUuid { get; set; }

    [JsonPropertyName("fields")]
    public IEnumerable<V1DocumentCreateFieldsItem> Fields { get; set; } =
        new List<V1DocumentCreateFieldsItem>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
