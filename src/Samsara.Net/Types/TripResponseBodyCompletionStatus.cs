using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<TripResponseBodyCompletionStatus>))]
[Serializable]
public readonly record struct TripResponseBodyCompletionStatus : IStringEnum
{
    public static readonly TripResponseBodyCompletionStatus InProgress = new(Values.InProgress);

    public static readonly TripResponseBodyCompletionStatus Completed = new(Values.Completed);

    public TripResponseBodyCompletionStatus(string value)
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
    public static TripResponseBodyCompletionStatus FromCustom(string value)
    {
        return new TripResponseBodyCompletionStatus(value);
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

    public static bool operator ==(TripResponseBodyCompletionStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(TripResponseBodyCompletionStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(TripResponseBodyCompletionStatus value) => value.Value;

    public static explicit operator TripResponseBodyCompletionStatus(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string InProgress = "inProgress";

        public const string Completed = "completed";
    }
}
