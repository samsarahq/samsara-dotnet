using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<DvirStreamResponseDataResponseBodyType>))]
[Serializable]
public readonly record struct DvirStreamResponseDataResponseBodyType : IStringEnum
{
    public static readonly DvirStreamResponseDataResponseBodyType PreTrip = new(Values.PreTrip);

    public static readonly DvirStreamResponseDataResponseBodyType PostTrip = new(Values.PostTrip);

    public static readonly DvirStreamResponseDataResponseBodyType Mechanic = new(Values.Mechanic);

    public static readonly DvirStreamResponseDataResponseBodyType Unspecified = new(
        Values.Unspecified
    );

    public DvirStreamResponseDataResponseBodyType(string value)
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
    public static DvirStreamResponseDataResponseBodyType FromCustom(string value)
    {
        return new DvirStreamResponseDataResponseBodyType(value);
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

    public static bool operator ==(DvirStreamResponseDataResponseBodyType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DvirStreamResponseDataResponseBodyType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DvirStreamResponseDataResponseBodyType value) =>
        value.Value;

    public static explicit operator DvirStreamResponseDataResponseBodyType(string value) =>
        new(value);

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
