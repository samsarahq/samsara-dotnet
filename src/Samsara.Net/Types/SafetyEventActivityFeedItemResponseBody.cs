using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Safety event activity feed item.
/// </summary>
public record SafetyEventActivityFeedItemResponseBody
{
    /// <summary>
    /// The ID of the activity event feed line item.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("safetyEvent")]
    public required SafetyEventObjectResponseBody SafetyEvent { get; set; }

    /// <summary>
    /// The time the activity occurred in the corresponding safety event in RFC 3339 milliseconds format.
    /// </summary>
    [JsonPropertyName("time")]
    public required string Time { get; set; }

    /// <summary>
    /// The type of activity that occurred in the safety event. We currently only support CoachingStateActivityType, BehaviorLabelActivityType, and CreateSafetyEventActivityType, but we may add support for more activity types in the future.  Valid values: `BehaviorLabelActivityType`, `CoachingStateActivityType`, `CreateSafetyEventActivityType`
    /// </summary>
    [JsonPropertyName("type")]
    public required SafetyEventActivityFeedItemResponseBodyType Type { get; set; }

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
