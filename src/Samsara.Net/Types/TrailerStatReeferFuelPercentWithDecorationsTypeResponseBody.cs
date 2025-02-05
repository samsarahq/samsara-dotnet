using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record TrailerStatReeferFuelPercentWithDecorationsTypeResponseBody
{
    [JsonPropertyName("decorations")]
    public TrailerStatDecorationResponseBody? Decorations { get; set; }

    /// <summary>
    /// UTC timestamp in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("time")]
    public required string Time { get; set; }

    /// <summary>
    /// The fuel level in percentage points (e.g. `99`, `50`, etc).
    /// </summary>
    [JsonPropertyName("value")]
    public required long Value { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
