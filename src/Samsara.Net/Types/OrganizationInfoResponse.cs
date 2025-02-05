using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record OrganizationInfoResponse
{
    [JsonPropertyName("data")]
    public OrganizationInfo? Data { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
