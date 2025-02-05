using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

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

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
