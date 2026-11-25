using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<BehaviorResponseBodyCoachingStatus>))]
[Serializable]
public readonly record struct BehaviorResponseBodyCoachingStatus : IStringEnum
{
    public static readonly BehaviorResponseBodyCoachingStatus Completed = new(Values.Completed);

    public static readonly BehaviorResponseBodyCoachingStatus Dismissed = new(Values.Dismissed);

    public static readonly BehaviorResponseBodyCoachingStatus Disputed = new(Values.Disputed);

    public static readonly BehaviorResponseBodyCoachingStatus Incomplete = new(Values.Incomplete);

    public static readonly BehaviorResponseBodyCoachingStatus Opened = new(Values.Opened);

    public static readonly BehaviorResponseBodyCoachingStatus Unknown = new(Values.Unknown);

    public BehaviorResponseBodyCoachingStatus(string value)
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
    public static BehaviorResponseBodyCoachingStatus FromCustom(string value)
    {
        return new BehaviorResponseBodyCoachingStatus(value);
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

    public static bool operator ==(BehaviorResponseBodyCoachingStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(BehaviorResponseBodyCoachingStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(BehaviorResponseBodyCoachingStatus value) => value.Value;

    public static explicit operator BehaviorResponseBodyCoachingStatus(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Completed = "completed";

        public const string Dismissed = "dismissed";

        public const string Disputed = "disputed";

        public const string Incomplete = "incomplete";

        public const string Opened = "opened";

        public const string Unknown = "unknown";
    }
}
