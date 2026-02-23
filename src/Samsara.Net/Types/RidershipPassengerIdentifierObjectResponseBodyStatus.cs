using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<RidershipPassengerIdentifierObjectResponseBodyStatus>))]
[Serializable]
public readonly record struct RidershipPassengerIdentifierObjectResponseBodyStatus : IStringEnum
{
    public static readonly RidershipPassengerIdentifierObjectResponseBodyStatus Active = new(
        Values.Active
    );

    public static readonly RidershipPassengerIdentifierObjectResponseBodyStatus Inactive = new(
        Values.Inactive
    );

    public static readonly RidershipPassengerIdentifierObjectResponseBodyStatus Unknown = new(
        Values.Unknown
    );

    public RidershipPassengerIdentifierObjectResponseBodyStatus(string value)
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
    public static RidershipPassengerIdentifierObjectResponseBodyStatus FromCustom(string value)
    {
        return new RidershipPassengerIdentifierObjectResponseBodyStatus(value);
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
        RidershipPassengerIdentifierObjectResponseBodyStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        RidershipPassengerIdentifierObjectResponseBodyStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        RidershipPassengerIdentifierObjectResponseBodyStatus value
    ) => value.Value;

    public static explicit operator RidershipPassengerIdentifierObjectResponseBodyStatus(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Active = "active";

        public const string Inactive = "inactive";

        public const string Unknown = "unknown";
    }
}
