using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record FormSubmissionRequestAssetValueObjectRequestBody
{
    [JsonPropertyName("asset")]
    public required FormSubmissionRequestAssetObjectRequestBody Asset { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
