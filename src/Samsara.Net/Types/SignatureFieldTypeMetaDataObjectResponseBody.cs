using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record SignatureFieldTypeMetaDataObjectResponseBody
{
    /// <summary>
    /// The signature field legal text.
    /// </summary>
    [JsonPropertyName("legalText")]
    public string? LegalText { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
