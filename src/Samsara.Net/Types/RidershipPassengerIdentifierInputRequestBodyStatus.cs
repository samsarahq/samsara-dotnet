using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<RidershipPassengerIdentifierInputRequestBodyStatus>))]
[Serializable]
public readonly record struct RidershipPassengerIdentifierInputRequestBodyStatus : IStringEnum
{
    public static readonly RidershipPassengerIdentifierInputRequestBodyStatus Active = new(
        Values.Active
    );

    public static readonly RidershipPassengerIdentifierInputRequestBodyStatus Inactive = new(
        Values.Inactive
    );

    public static readonly RidershipPassengerIdentifierInputRequestBodyStatus Unknown = new(
        Values.Unknown
    );

    public RidershipPassengerIdentifierInputRequestBodyStatus(string value)
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
    public static RidershipPassengerIdentifierInputRequestBodyStatus FromCustom(string value)
    {
        return new RidershipPassengerIdentifierInputRequestBodyStatus(value);
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
        RidershipPassengerIdentifierInputRequestBodyStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        RidershipPassengerIdentifierInputRequestBodyStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        RidershipPassengerIdentifierInputRequestBodyStatus value
    ) => value.Value;

    public static explicit operator RidershipPassengerIdentifierInputRequestBodyStatus(
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
