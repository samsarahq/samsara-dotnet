using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<VoiceCoachingSettingsObjectResponseBodyEventsToCoachItem>)
)]
[Serializable]
public readonly record struct VoiceCoachingSettingsObjectResponseBodyEventsToCoachItem : IStringEnum
{
    public static readonly VoiceCoachingSettingsObjectResponseBodyEventsToCoachItem Crash = new(
        Values.Crash
    );

    public static readonly VoiceCoachingSettingsObjectResponseBodyEventsToCoachItem InCabSpeeding =
        new(Values.InCabSpeeding);

    public static readonly VoiceCoachingSettingsObjectResponseBodyEventsToCoachItem MaximumSpeed =
        new(Values.MaximumSpeed);

    public static readonly VoiceCoachingSettingsObjectResponseBodyEventsToCoachItem SeatbeltUnbuckled =
        new(Values.SeatbeltUnbuckled);

    public static readonly VoiceCoachingSettingsObjectResponseBodyEventsToCoachItem HarshDriving =
        new(Values.HarshDriving);

    public VoiceCoachingSettingsObjectResponseBodyEventsToCoachItem(string value)
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
    public static VoiceCoachingSettingsObjectResponseBodyEventsToCoachItem FromCustom(string value)
    {
        return new VoiceCoachingSettingsObjectResponseBodyEventsToCoachItem(value);
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
        VoiceCoachingSettingsObjectResponseBodyEventsToCoachItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        VoiceCoachingSettingsObjectResponseBodyEventsToCoachItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        VoiceCoachingSettingsObjectResponseBodyEventsToCoachItem value
    ) => value.Value;

    public static explicit operator VoiceCoachingSettingsObjectResponseBodyEventsToCoachItem(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Crash = "crash";

        public const string InCabSpeeding = "inCabSpeeding";

        public const string MaximumSpeed = "maximumSpeed";

        public const string SeatbeltUnbuckled = "seatbeltUnbuckled";

        public const string HarshDriving = "harshDriving";
    }
}
