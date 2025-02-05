using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record FormSubmittedResponseBody
{
    [JsonPropertyName("form")]
    public required FormSubmissionResponseObjectResponseBody Form { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
