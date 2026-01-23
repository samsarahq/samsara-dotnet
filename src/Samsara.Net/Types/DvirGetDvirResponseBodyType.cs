using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<DvirGetDvirResponseBodyType>))]
[Serializable]
public readonly record struct DvirGetDvirResponseBodyType : IStringEnum
{
    public static readonly DvirGetDvirResponseBodyType PreTrip = new(Values.PreTrip);

    public static readonly DvirGetDvirResponseBodyType PostTrip = new(Values.PostTrip);

    public static readonly DvirGetDvirResponseBodyType Mechanic = new(Values.Mechanic);

    public static readonly DvirGetDvirResponseBodyType Unspecified = new(Values.Unspecified);

    public DvirGetDvirResponseBodyType(string value)
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
    public static DvirGetDvirResponseBodyType FromCustom(string value)
    {
        return new DvirGetDvirResponseBodyType(value);
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

    public static bool operator ==(DvirGetDvirResponseBodyType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DvirGetDvirResponseBodyType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DvirGetDvirResponseBodyType value) => value.Value;

    public static explicit operator DvirGetDvirResponseBodyType(string value) => new(value);

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
