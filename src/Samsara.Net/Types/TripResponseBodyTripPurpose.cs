using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<TripResponseBodyTripPurpose>))]
[Serializable]
public readonly record struct TripResponseBodyTripPurpose : IStringEnum
{
    public static readonly TripResponseBodyTripPurpose Unknown = new(Values.Unknown);

    public static readonly TripResponseBodyTripPurpose Unassigned = new(Values.Unassigned);

    public static readonly TripResponseBodyTripPurpose Personal = new(Values.Personal);

    public static readonly TripResponseBodyTripPurpose Business = new(Values.Business);

    public static readonly TripResponseBodyTripPurpose Commute = new(Values.Commute);

    public TripResponseBodyTripPurpose(string value)
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
    public static TripResponseBodyTripPurpose FromCustom(string value)
    {
        return new TripResponseBodyTripPurpose(value);
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

    public static bool operator ==(TripResponseBodyTripPurpose value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(TripResponseBodyTripPurpose value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(TripResponseBodyTripPurpose value) => value.Value;

    public static explicit operator TripResponseBodyTripPurpose(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Unknown = "unknown";

        public const string Unassigned = "unassigned";

        public const string Personal = "personal";

        public const string Business = "business";

        public const string Commute = "commute";
    }
}
