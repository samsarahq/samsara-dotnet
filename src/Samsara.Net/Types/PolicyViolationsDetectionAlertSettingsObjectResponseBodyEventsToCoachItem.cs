using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<PolicyViolationsDetectionAlertSettingsObjectResponseBodyEventsToCoachItem>)
)]
[Serializable]
public readonly record struct PolicyViolationsDetectionAlertSettingsObjectResponseBodyEventsToCoachItem
    : IStringEnum
{
    public static readonly PolicyViolationsDetectionAlertSettingsObjectResponseBodyEventsToCoachItem NoSeatbelt =
        new(Values.NoSeatbelt);

    public static readonly PolicyViolationsDetectionAlertSettingsObjectResponseBodyEventsToCoachItem NoMask =
        new(Values.NoMask);

    public static readonly PolicyViolationsDetectionAlertSettingsObjectResponseBodyEventsToCoachItem MobileUsage =
        new(Values.MobileUsage);

    public static readonly PolicyViolationsDetectionAlertSettingsObjectResponseBodyEventsToCoachItem Smoking =
        new(Values.Smoking);

    public static readonly PolicyViolationsDetectionAlertSettingsObjectResponseBodyEventsToCoachItem EatingDrinking =
        new(Values.EatingDrinking);

    public static readonly PolicyViolationsDetectionAlertSettingsObjectResponseBodyEventsToCoachItem InwardCameraObstruction =
        new(Values.InwardCameraObstruction);

    public static readonly PolicyViolationsDetectionAlertSettingsObjectResponseBodyEventsToCoachItem OutwardCameraObstruction =
        new(Values.OutwardCameraObstruction);

    public PolicyViolationsDetectionAlertSettingsObjectResponseBodyEventsToCoachItem(string value)
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
    public static PolicyViolationsDetectionAlertSettingsObjectResponseBodyEventsToCoachItem FromCustom(
        string value
    )
    {
        return new PolicyViolationsDetectionAlertSettingsObjectResponseBodyEventsToCoachItem(value);
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
        PolicyViolationsDetectionAlertSettingsObjectResponseBodyEventsToCoachItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PolicyViolationsDetectionAlertSettingsObjectResponseBodyEventsToCoachItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PolicyViolationsDetectionAlertSettingsObjectResponseBodyEventsToCoachItem value
    ) => value.Value;

    public static explicit operator PolicyViolationsDetectionAlertSettingsObjectResponseBodyEventsToCoachItem(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string NoSeatbelt = "noSeatbelt";

        public const string NoMask = "noMask";

        public const string MobileUsage = "mobileUsage";

        public const string Smoking = "smoking";

        public const string EatingDrinking = "eatingDrinking";

        public const string InwardCameraObstruction = "inwardCameraObstruction";

        public const string OutwardCameraObstruction = "outwardCameraObstruction";
    }
}
