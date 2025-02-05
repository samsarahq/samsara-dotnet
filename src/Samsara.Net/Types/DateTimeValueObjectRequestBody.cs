using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record DateTimeValueObjectRequestBody
{
    /// <summary>
    /// Date time value inin RFC 3339 format.
    /// </summary>
    [JsonPropertyName("dateTime")]
    public DateTime? DateTime { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
