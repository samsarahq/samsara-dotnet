using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<DvirSubmittedDeviceTriggerDetailsObjectRequestBodyDvirSubmissionTypesItem>)
)]
[Serializable]
public readonly record struct DvirSubmittedDeviceTriggerDetailsObjectRequestBodyDvirSubmissionTypesItem
    : IStringEnum
{
    public static readonly DvirSubmittedDeviceTriggerDetailsObjectRequestBodyDvirSubmissionTypesItem SafeNoDefects =
        new(Values.SafeNoDefects);

    public static readonly DvirSubmittedDeviceTriggerDetailsObjectRequestBodyDvirSubmissionTypesItem SafeWithDefects =
        new(Values.SafeWithDefects);

    public static readonly DvirSubmittedDeviceTriggerDetailsObjectRequestBodyDvirSubmissionTypesItem Unsafe =
        new(Values.Unsafe);

    public DvirSubmittedDeviceTriggerDetailsObjectRequestBodyDvirSubmissionTypesItem(string value)
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
    public static DvirSubmittedDeviceTriggerDetailsObjectRequestBodyDvirSubmissionTypesItem FromCustom(
        string value
    )
    {
        return new DvirSubmittedDeviceTriggerDetailsObjectRequestBodyDvirSubmissionTypesItem(value);
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
        DvirSubmittedDeviceTriggerDetailsObjectRequestBodyDvirSubmissionTypesItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DvirSubmittedDeviceTriggerDetailsObjectRequestBodyDvirSubmissionTypesItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DvirSubmittedDeviceTriggerDetailsObjectRequestBodyDvirSubmissionTypesItem value
    ) => value.Value;

    public static explicit operator DvirSubmittedDeviceTriggerDetailsObjectRequestBodyDvirSubmissionTypesItem(
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
