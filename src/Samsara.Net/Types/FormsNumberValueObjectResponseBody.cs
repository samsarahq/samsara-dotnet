using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record FormsNumberValueObjectResponseBody
{
    /// <summary>
    /// Number value.
    /// </summary>
    [JsonPropertyName("value")]
    public required double Value { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
