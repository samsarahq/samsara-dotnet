using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<SafetyEventDismissalReasonResponseBodyCode>))]
[Serializable]
public readonly record struct SafetyEventDismissalReasonResponseBodyCode : IStringEnum
{
    public static readonly SafetyEventDismissalReasonResponseBodyCode Incorrect = new(
        Values.Incorrect
    );

    public static readonly SafetyEventDismissalReasonResponseBodyCode MinorEvent = new(
        Values.MinorEvent
    );

    public static readonly SafetyEventDismissalReasonResponseBodyCode Other = new(Values.Other);

    public SafetyEventDismissalReasonResponseBodyCode(string value)
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
    public static SafetyEventDismissalReasonResponseBodyCode FromCustom(string value)
    {
        return new SafetyEventDismissalReasonResponseBodyCode(value);
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
        SafetyEventDismissalReasonResponseBodyCode value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        SafetyEventDismissalReasonResponseBodyCode value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(SafetyEventDismissalReasonResponseBodyCode value) =>
        value.Value;

    public static explicit operator SafetyEventDismissalReasonResponseBodyCode(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Incorrect = "incorrect";

        public const string MinorEvent = "minorEvent";

        public const string Other = "other";
    }
}
