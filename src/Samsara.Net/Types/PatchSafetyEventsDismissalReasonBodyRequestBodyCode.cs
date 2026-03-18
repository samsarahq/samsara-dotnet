using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<PatchSafetyEventsDismissalReasonBodyRequestBodyCode>))]
[Serializable]
public readonly record struct PatchSafetyEventsDismissalReasonBodyRequestBodyCode : IStringEnum
{
    public static readonly PatchSafetyEventsDismissalReasonBodyRequestBodyCode Incorrect = new(
        Values.Incorrect
    );

    public static readonly PatchSafetyEventsDismissalReasonBodyRequestBodyCode MinorEvent = new(
        Values.MinorEvent
    );

    public static readonly PatchSafetyEventsDismissalReasonBodyRequestBodyCode Other = new(
        Values.Other
    );

    public PatchSafetyEventsDismissalReasonBodyRequestBodyCode(string value)
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
    public static PatchSafetyEventsDismissalReasonBodyRequestBodyCode FromCustom(string value)
    {
        return new PatchSafetyEventsDismissalReasonBodyRequestBodyCode(value);
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
        PatchSafetyEventsDismissalReasonBodyRequestBodyCode value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PatchSafetyEventsDismissalReasonBodyRequestBodyCode value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PatchSafetyEventsDismissalReasonBodyRequestBodyCode value
    ) => value.Value;

    public static explicit operator PatchSafetyEventsDismissalReasonBodyRequestBodyCode(
        string value
    ) => new(value);

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
