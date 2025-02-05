using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record DriverDocumentSubmittedDetailsObjectResponseBody
{
    /// <summary>
    /// Specific template IDs to be alerted on.
    /// </summary>
    [JsonPropertyName("templateIds")]
    public IEnumerable<string> TemplateIds { get; set; } = new List<string>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
