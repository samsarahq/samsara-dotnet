using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record FormSubmissionRequestTextValueObjectRequestBody
{
    [JsonPropertyName("value")]
    public required string Value { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
