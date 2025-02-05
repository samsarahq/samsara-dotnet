using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record LiveSharingLinksCreateLiveSharingLinkResponseBody
{
    [JsonPropertyName("data")]
    public required LiveSharingLinkFullResponseObjectResponseBody Data { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
