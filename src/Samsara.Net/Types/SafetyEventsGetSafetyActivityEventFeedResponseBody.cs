using System.Text.Json;
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

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
