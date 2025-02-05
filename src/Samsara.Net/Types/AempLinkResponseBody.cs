using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record AempLinkResponseBody
{
    /// <summary>
    /// The hyperlink of the relationship.
    /// </summary>
    [JsonPropertyName("href")]
    public required string Href { get; set; }

    /// <summary>
    /// The link relationship to the current call.
    /// </summary>
    [JsonPropertyName("rel")]
    public required string Rel { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
