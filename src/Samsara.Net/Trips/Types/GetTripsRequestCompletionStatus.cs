using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Trips;

[JsonConverter(typeof(StringEnumSerializer<GetTripsRequestCompletionStatus>))]
[Serializable]
public readonly record struct GetTripsRequestCompletionStatus : IStringEnum
{
    public static readonly GetTripsRequestCompletionStatus InProgress = new(Values.InProgress);

    public static readonly GetTripsRequestCompletionStatus Completed = new(Values.Completed);

    public static readonly GetTripsRequestCompletionStatus All = new(Values.All);

    public GetTripsRequestCompletionStatus(string value)
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
    public static GetTripsRequestCompletionStatus FromCustom(string value)
    {
        return new GetTripsRequestCompletionStatus(value);
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

    public static bool operator ==(GetTripsRequestCompletionStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(GetTripsRequestCompletionStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(GetTripsRequestCompletionStatus value) => value.Value;

    public static explicit operator GetTripsRequestCompletionStatus(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string InProgress = "inProgress";

        public const string Completed = "completed";

        public const string All = "all";
    }
}
