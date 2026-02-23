using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<RidershipPassengerIdentifierObjectResponseBodyType>))]
[Serializable]
public readonly record struct RidershipPassengerIdentifierObjectResponseBodyType : IStringEnum
{
    public static readonly RidershipPassengerIdentifierObjectResponseBodyType Rfid = new(
        Values.Rfid
    );

    public static readonly RidershipPassengerIdentifierObjectResponseBodyType Unknown = new(
        Values.Unknown
    );

    public RidershipPassengerIdentifierObjectResponseBodyType(string value)
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
    public static RidershipPassengerIdentifierObjectResponseBodyType FromCustom(string value)
    {
        return new RidershipPassengerIdentifierObjectResponseBodyType(value);
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

    public static bool operator ==(
        RidershipPassengerIdentifierObjectResponseBodyType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        RidershipPassengerIdentifierObjectResponseBodyType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        RidershipPassengerIdentifierObjectResponseBodyType value
    ) => value.Value;

    public static explicit operator RidershipPassengerIdentifierObjectResponseBodyType(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Rfid = "rfid";

        public const string Unknown = "unknown";
    }
}
