using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record FormTemplatesGetFormTemplatesResponseBody
{
    /// <summary>
    /// List of form templates.
    /// </summary>
    [JsonPropertyName("data")]
    public IEnumerable<FormTemplateResponseObjectResponseBody> Data { get; set; } =
        new List<FormTemplateResponseObjectResponseBody>();

    [JsonPropertyName("pagination")]
    public required GoaPaginationResponseResponseBody Pagination { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
