using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<DvirSubmittedDeviceTriggerDetailsObjectResponseBodyDvirSubmissionTypesItem>)
)]
[Serializable]
public readonly record struct DvirSubmittedDeviceTriggerDetailsObjectResponseBodyDvirSubmissionTypesItem
    : IStringEnum
{
    public static readonly DvirSubmittedDeviceTriggerDetailsObjectResponseBodyDvirSubmissionTypesItem SafeNoDefects =
        new(Values.SafeNoDefects);

    public static readonly DvirSubmittedDeviceTriggerDetailsObjectResponseBodyDvirSubmissionTypesItem SafeWithDefects =
        new(Values.SafeWithDefects);

    public static readonly DvirSubmittedDeviceTriggerDetailsObjectResponseBodyDvirSubmissionTypesItem Unsafe =
        new(Values.Unsafe);

    public DvirSubmittedDeviceTriggerDetailsObjectResponseBodyDvirSubmissionTypesItem(string value)
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
    public static DvirSubmittedDeviceTriggerDetailsObjectResponseBodyDvirSubmissionTypesItem FromCustom(
        string value
    )
    {
        return new DvirSubmittedDeviceTriggerDetailsObjectResponseBodyDvirSubmissionTypesItem(
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
        DvirSubmittedDeviceTriggerDetailsObjectResponseBodyDvirSubmissionTypesItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DvirSubmittedDeviceTriggerDetailsObjectResponseBodyDvirSubmissionTypesItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DvirSubmittedDeviceTriggerDetailsObjectResponseBodyDvirSubmissionTypesItem value
    ) => value.Value;

    public static explicit operator DvirSubmittedDeviceTriggerDetailsObjectResponseBodyDvirSubmissionTypesItem(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string SafeNoDefects = "SAFE_NO_DEFECTS";

        public const string SafeWithDefects = "SAFE_WITH_DEFECTS";

        public const string Unsafe = "UNSAFE";
    }
}
