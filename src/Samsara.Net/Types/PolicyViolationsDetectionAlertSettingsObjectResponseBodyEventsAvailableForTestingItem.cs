using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<PolicyViolationsDetectionAlertSettingsObjectResponseBodyEventsAvailableForTestingItem>)
)]
[Serializable]
public readonly record struct PolicyViolationsDetectionAlertSettingsObjectResponseBodyEventsAvailableForTestingItem
    : IStringEnum
{
    public static readonly PolicyViolationsDetectionAlertSettingsObjectResponseBodyEventsAvailableForTestingItem MobileUsage =
        new(Values.MobileUsage);

    public static readonly PolicyViolationsDetectionAlertSettingsObjectResponseBodyEventsAvailableForTestingItem Smoking =
        new(Values.Smoking);

    public static readonly PolicyViolationsDetectionAlertSettingsObjectResponseBodyEventsAvailableForTestingItem EatingDrinking =
        new(Values.EatingDrinking);

    public static readonly PolicyViolationsDetectionAlertSettingsObjectResponseBodyEventsAvailableForTestingItem InwardCameraObstruction =
        new(Values.InwardCameraObstruction);

    public static readonly PolicyViolationsDetectionAlertSettingsObjectResponseBodyEventsAvailableForTestingItem OutwardCameraObstruction =
        new(Values.OutwardCameraObstruction);

    public PolicyViolationsDetectionAlertSettingsObjectResponseBodyEventsAvailableForTestingItem(
        string value
    )
    {
        Value = value;
    }

    /// <summary>
    /// The string value of the enum.
    /// </summary>
    public string Value { get; }

    /// <summary>
    /// Create a string enum with the given value.
    /// </summary>
    public static PolicyViolationsDetectionAlertSettingsObjectResponseBodyEventsAvailableForTestingItem FromCustom(
        string value
    )
    {
        return new PolicyViolationsDetectionAlertSettingsObjectResponseBodyEventsAvailableForTestingItem(
            value
        );
    }

    public bool Equals(string? other)
    {
        return Value.Equals(other);
    }

    /// <summary>
    /// Returns the string value of the enum.
    /// </summary>
    public override string ToString()
    {
        return Value;
    }

    public static bool operator ==(
        PolicyViolationsDetectionAlertSettingsObjectResponseBodyEventsAvailableForTestingItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PolicyViolationsDetectionAlertSettingsObjectResponseBodyEventsAvailableForTestingItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PolicyViolationsDetectionAlertSettingsObjectResponseBodyEventsAvailableForTestingItem value
    ) => value.Value;

    public static explicit operator PolicyViolationsDetectionAlertSettingsObjectResponseBodyEventsAvailableForTestingItem(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string MobileUsage = "mobileUsage";

        public const string Smoking = "smoking";

        public const string EatingDrinking = "eatingDrinking";

        public const string InwardCameraObstruction = "inwardCameraObstruction";

        public const string OutwardCameraObstruction = "outwardCameraObstruction";
    }
}
