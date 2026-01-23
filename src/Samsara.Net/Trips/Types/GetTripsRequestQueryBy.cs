using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Trips;

[JsonConverter(typeof(StringEnumSerializer<GetTripsRequestQueryBy>))]
[Serializable]
public readonly record struct GetTripsRequestQueryBy : IStringEnum
{
    public static readonly GetTripsRequestQueryBy UpdatedAtTime = new(Values.UpdatedAtTime);

    public static readonly GetTripsRequestQueryBy TripStartTime = new(Values.TripStartTime);

    public GetTripsRequestQueryBy(string value)
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
    public static GetTripsRequestQueryBy FromCustom(string value)
    {
        return new GetTripsRequestQueryBy(value);
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

    public static bool operator ==(GetTripsRequestQueryBy value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(GetTripsRequestQueryBy value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(GetTripsRequestQueryBy value) => value.Value;

    public static explicit operator GetTripsRequestQueryBy(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string UpdatedAtTime = "updatedAtTime";

        public const string TripStartTime = "tripStartTime";
    }
}
