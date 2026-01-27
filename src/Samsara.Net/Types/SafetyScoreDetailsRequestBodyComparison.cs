using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<SafetyScoreDetailsRequestBodyComparison>))]
[Serializable]
public readonly record struct SafetyScoreDetailsRequestBodyComparison : IStringEnum
{
    public static readonly SafetyScoreDetailsRequestBodyComparison EqualTo = new(Values.EqualTo);

    public static readonly SafetyScoreDetailsRequestBodyComparison GreaterThan = new(
        Values.GreaterThan
    );

    public static readonly SafetyScoreDetailsRequestBodyComparison GreaterThanOrEqualTo = new(
        Values.GreaterThanOrEqualTo
    );

    public static readonly SafetyScoreDetailsRequestBodyComparison LessThan = new(Values.LessThan);

    public static readonly SafetyScoreDetailsRequestBodyComparison LessThanOrEqualTo = new(
        Values.LessThanOrEqualTo
    );

    public SafetyScoreDetailsRequestBodyComparison(string value)
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
    public static SafetyScoreDetailsRequestBodyComparison FromCustom(string value)
    {
        return new SafetyScoreDetailsRequestBodyComparison(value);
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

    public static bool operator ==(SafetyScoreDetailsRequestBodyComparison value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SafetyScoreDetailsRequestBodyComparison value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SafetyScoreDetailsRequestBodyComparison value) =>
        value.Value;

    public static explicit operator SafetyScoreDetailsRequestBodyComparison(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string EqualTo = "EQUAL_TO";

        public const string GreaterThan = "GREATER_THAN";

        public const string GreaterThanOrEqualTo = "GREATER_THAN_OR_EQUAL_TO";

        public const string LessThan = "LESS_THAN";

        public const string LessThanOrEqualTo = "LESS_THAN_OR_EQUAL_TO";
    }
}
