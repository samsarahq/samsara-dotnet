using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[JsonConverter(typeof(StringEnumSerializer<GetTagSafetyScoresRequestScoreType>))]
[Serializable]
public readonly record struct GetTagSafetyScoresRequestScoreType : IStringEnum
{
    public static readonly GetTagSafetyScoresRequestScoreType Driver = new(Values.Driver);

    public static readonly GetTagSafetyScoresRequestScoreType Vehicle = new(Values.Vehicle);

    public GetTagSafetyScoresRequestScoreType(string value)
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
    public static GetTagSafetyScoresRequestScoreType FromCustom(string value)
    {
        return new GetTagSafetyScoresRequestScoreType(value);
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

    public static bool operator ==(GetTagSafetyScoresRequestScoreType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(GetTagSafetyScoresRequestScoreType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(GetTagSafetyScoresRequestScoreType value) => value.Value;

    public static explicit operator GetTagSafetyScoresRequestScoreType(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Driver = "driver";

        public const string Vehicle = "vehicle";
    }
}
