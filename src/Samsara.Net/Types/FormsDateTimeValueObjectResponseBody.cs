using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record FormsDateTimeValueObjectResponseBody
{
    /// <summary>
    /// The type of datetime format.  Valid values: `datetime`, `date`, `time`
    /// </summary>
    [JsonPropertyName("type")]
    public required FormsDateTimeValueObjectResponseBodyType Type { get; set; }

    /// <summary>
    /// UTC timestamp in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("value")]
    public required DateTime Value { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
