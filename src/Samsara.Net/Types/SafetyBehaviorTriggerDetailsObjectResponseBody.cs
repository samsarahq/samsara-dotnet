using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Details specific to Safety Behavior
/// </summary>
[Serializable]
public record SafetyBehaviorTriggerDetailsObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("behaviorCount")]
    public BehaviorCountDetailsResponseBody? BehaviorCount { get; set; }

    /// <summary>
    /// On which safety behaviors to trigger on.
    /// </summary>
    [JsonPropertyName("behaviors")]
    public IEnumerable<SafetyBehaviorTriggerDetailsObjectResponseBodyBehaviorsItem> Behaviors { get; set; } =
        new List<SafetyBehaviorTriggerDetailsObjectResponseBodyBehaviorsItem>();

    [JsonPropertyName("drivers")]
    public DriverOrTagIdsDetailsResponseBody? Drivers { get; set; }

    [JsonPropertyName("safetyScore")]
    public SafetyScoreDetailsResponseBody? SafetyScore { get; set; }

    /// <summary>
    /// On which event severity to trigger on.
    /// </summary>
    [JsonPropertyName("severities")]
    public IEnumerable<SafetyBehaviorTriggerDetailsObjectResponseBodySeveritiesItem>? Severities { get; set; }

    /// <summary>
    /// On which event status to trigger on.
    /// </summary>
    [JsonPropertyName("statuses")]
    public IEnumerable<SafetyBehaviorTriggerDetailsObjectResponseBodyStatusesItem>? Statuses { get; set; }

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
