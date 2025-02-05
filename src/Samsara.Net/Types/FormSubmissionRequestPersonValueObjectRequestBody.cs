using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record FormSubmissionRequestPersonValueObjectRequestBody
{
    [JsonPropertyName("person")]
    public required FormSubmissionRequestPersonObjectRequestBody Person { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
