using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Details specific to Safety Behavior
/// </summary>
[Serializable]
public record SafetyBehaviorTriggerDetailsObjectRequestBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("behaviorCount")]
    public BehaviorCountDetailsRequestBody? BehaviorCount { get; set; }

    /// <summary>
    /// On which safety behaviors to trigger on.
    /// </summary>
    [JsonPropertyName("behaviors")]
    public IEnumerable<SafetyBehaviorTriggerDetailsObjectRequestBodyBehaviorsItem> Behaviors { get; set; } =
        new List<SafetyBehaviorTriggerDetailsObjectRequestBodyBehaviorsItem>();

    [JsonPropertyName("drivers")]
    public DriverOrTagIdsDetailsRequestBody? Drivers { get; set; }

    [JsonPropertyName("safetyScore")]
    public SafetyScoreDetailsRequestBody? SafetyScore { get; set; }

    /// <summary>
    /// On which event severity to trigger on.
    /// </summary>
    [JsonPropertyName("severities")]
    public IEnumerable<SafetyBehaviorTriggerDetailsObjectRequestBodySeveritiesItem>? Severities { get; set; }

    /// <summary>
    /// On which event status to trigger on.
    /// </summary>
    [JsonPropertyName("statuses")]
    public IEnumerable<SafetyBehaviorTriggerDetailsObjectRequestBodyStatusesItem>? Statuses { get; set; }

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
