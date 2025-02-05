using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record AlertObjectProductResponseBody
{
    /// <summary>
    /// The short name associated with the product.
    /// </summary>
    [JsonPropertyName("shortName")]
    public string? ShortName { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
