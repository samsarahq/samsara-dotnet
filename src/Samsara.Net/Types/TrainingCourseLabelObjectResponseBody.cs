using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Label of the training course.
/// </summary>
[Serializable]
public record TrainingCourseLabelObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Name of the course label. Valid values: “safety”.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Type of the course label. Valid values when course.label.name is ‘safety’: accel, braking, crashSharpTurn, rolloverProtection, yawControl, speeding, rolledStopSign, tileRollingRailroad, seatbeltPolicy, nearCollision, phonePolicy, drowsy, defensiveDriving, driverObstructionPolicy, didNotYield, distractedDriving, tailgating, laneDeparture, lateResponse, ranRedLight, forwardCollisionWarning, foodDrinkPolicy, smokingPolicy, maskPolicy, maxSpeed, severeSpeeding, drinkPolicy, foodPolicy, unknown.
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }

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
