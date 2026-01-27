using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Documents;

[Serializable]
public record GetDocumentRequest
{
    /// <summary>
    /// ID of the document
    /// </summary>
    [JsonIgnore]
    public required string Id { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
