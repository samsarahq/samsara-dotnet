using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record FormSubmissionRequestDateTimeValueObjectRequestBody
{
    /// <summary>
    /// The value of the user generated date/time field response. UTC timestamp in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("value")]
    public required DateTime Value { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
