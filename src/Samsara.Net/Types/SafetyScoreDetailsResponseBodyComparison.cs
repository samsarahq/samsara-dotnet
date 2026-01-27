using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<SafetyScoreDetailsResponseBodyComparison>))]
[Serializable]
public readonly record struct SafetyScoreDetailsResponseBodyComparison : IStringEnum
{
    public static readonly SafetyScoreDetailsResponseBodyComparison EqualTo = new(Values.EqualTo);

    public static readonly SafetyScoreDetailsResponseBodyComparison GreaterThan = new(
        Values.GreaterThan
    );

    public static readonly SafetyScoreDetailsResponseBodyComparison GreaterThanOrEqualTo = new(
        Values.GreaterThanOrEqualTo
    );

    public static readonly SafetyScoreDetailsResponseBodyComparison LessThan = new(Values.LessThan);

    public static readonly SafetyScoreDetailsResponseBodyComparison LessThanOrEqualTo = new(
        Values.LessThanOrEqualTo
    );

    public SafetyScoreDetailsResponseBodyComparison(string value)
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
    public static SafetyScoreDetailsResponseBodyComparison FromCustom(string value)
    {
        return new SafetyScoreDetailsResponseBodyComparison(value);
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
        SafetyScoreDetailsResponseBodyComparison value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        SafetyScoreDetailsResponseBodyComparison value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(SafetyScoreDetailsResponseBodyComparison value) =>
        value.Value;

    public static explicit operator SafetyScoreDetailsResponseBodyComparison(string value) =>
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
