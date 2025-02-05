using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record FormTemplateReferenceObjectRequestBody
{
    /// <summary>
    /// ID of the form template.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// ID of the form template revision.
    /// </summary>
    [JsonPropertyName("revisionId")]
    public required string RevisionId { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
