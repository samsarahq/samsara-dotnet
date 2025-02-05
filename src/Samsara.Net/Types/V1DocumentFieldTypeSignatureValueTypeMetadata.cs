using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1DocumentFieldTypeSignatureValueTypeMetadata
{
    /// <summary>
    /// Legal text displayed alongside signature
    /// </summary>
    [JsonPropertyName("legalText")]
    public string? LegalText { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
