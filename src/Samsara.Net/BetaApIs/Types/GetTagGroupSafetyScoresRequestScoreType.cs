using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[JsonConverter(typeof(StringEnumSerializer<GetTagGroupSafetyScoresRequestScoreType>))]
[Serializable]
public readonly record struct GetTagGroupSafetyScoresRequestScoreType : IStringEnum
{
    public static readonly GetTagGroupSafetyScoresRequestScoreType Driver = new(Values.Driver);

    public static readonly GetTagGroupSafetyScoresRequestScoreType Vehicle = new(Values.Vehicle);

    public GetTagGroupSafetyScoresRequestScoreType(string value)
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
    public static GetTagGroupSafetyScoresRequestScoreType FromCustom(string value)
    {
        return new GetTagGroupSafetyScoresRequestScoreType(value);
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

    public static bool operator ==(GetTagGroupSafetyScoresRequestScoreType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(GetTagGroupSafetyScoresRequestScoreType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(GetTagGroupSafetyScoresRequestScoreType value) =>
        value.Value;

    public static explicit operator GetTagGroupSafetyScoresRequestScoreType(string value) =>
        new(value);

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
