using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<VoiceCoachingSettingsObjectResponseBodyLanguage>))]
[Serializable]
public readonly record struct VoiceCoachingSettingsObjectResponseBodyLanguage : IStringEnum
{
    public static readonly VoiceCoachingSettingsObjectResponseBodyLanguage English = new(
        Values.English
    );

    public static readonly VoiceCoachingSettingsObjectResponseBodyLanguage Spanish = new(
        Values.Spanish
    );

    public static readonly VoiceCoachingSettingsObjectResponseBodyLanguage Dutch = new(
        Values.Dutch
    );

    public static readonly VoiceCoachingSettingsObjectResponseBodyLanguage EnglishUk = new(
        Values.EnglishUk
    );

    public static readonly VoiceCoachingSettingsObjectResponseBodyLanguage Italian = new(
        Values.Italian
    );

    public static readonly VoiceCoachingSettingsObjectResponseBodyLanguage French = new(
        Values.French
    );

    public static readonly VoiceCoachingSettingsObjectResponseBodyLanguage German = new(
        Values.German
    );

    public VoiceCoachingSettingsObjectResponseBodyLanguage(string value)
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
    public static VoiceCoachingSettingsObjectResponseBodyLanguage FromCustom(string value)
    {
        return new VoiceCoachingSettingsObjectResponseBodyLanguage(value);
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
        VoiceCoachingSettingsObjectResponseBodyLanguage value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        VoiceCoachingSettingsObjectResponseBodyLanguage value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(VoiceCoachingSettingsObjectResponseBodyLanguage value) =>
        value.Value;

    public static explicit operator VoiceCoachingSettingsObjectResponseBodyLanguage(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string English = "english";

        public const string Spanish = "spanish";

        public const string Dutch = "dutch";

        public const string EnglishUk = "englishUk";

        public const string Italian = "italian";

        public const string French = "french";

        public const string German = "german";
    }
}
