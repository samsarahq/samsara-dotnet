using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record LiveSharingLinksGetLiveSharingLinksResponseBody
{
    [JsonPropertyName("data")]
    public IEnumerable<LiveSharingLinkFullResponseObjectResponseBody> Data { get; set; } =
        new List<LiveSharingLinkFullResponseObjectResponseBody>();

    [JsonPropertyName("pagination")]
    public required GoaPaginationResponseResponseBody Pagination { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
