using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Label of the training course.
/// </summary>
public record TrainingCourseLabelObjectResponseBody
{
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
