using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record FormSubmissionRequestCheckBoxesValueObjectRequestBody
{
    [JsonPropertyName("valueIds")]
    public IEnumerable<string> ValueIds { get; set; } = new List<string>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
