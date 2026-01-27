using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<DvirType>))]
[Serializable]
public readonly record struct DvirType : IStringEnum
{
    public static readonly DvirType PreTrip = new(Values.PreTrip);

    public static readonly DvirType PostTrip = new(Values.PostTrip);

    public static readonly DvirType Mechanic = new(Values.Mechanic);

    public static readonly DvirType Unspecified = new(Values.Unspecified);

    public DvirType(string value)
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
    public static DvirType FromCustom(string value)
    {
        return new DvirType(value);
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

    public static bool operator ==(DvirType value1, string value2) => value1.Value.Equals(value2);

    public static bool operator !=(DvirType value1, string value2) => !value1.Value.Equals(value2);

    public static explicit operator string(DvirType value) => value.Value;

    public static explicit operator DvirType(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string PreTrip = "preTrip";

        public const string PostTrip = "postTrip";

        public const string Mechanic = "mechanic";

        public const string Unspecified = "unspecified";
    }
}
