using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record SafetyEventsGetSafetyActivityEventFeedResponseBody
{
    /// <summary>
    /// Paginated safety event activity feed limited to 10 events.
    /// </summary>
    [JsonPropertyName("data")]
    public IEnumerable<SafetyEventActivityFeedItemResponseBody> Data { get; set; } =
        new List<SafetyEventActivityFeedItemResponseBody>();

    [JsonPropertyName("pagination")]
    public required GoaPaginationResponseResponseBody Pagination { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
