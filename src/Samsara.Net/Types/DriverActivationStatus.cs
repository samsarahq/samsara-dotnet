using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<DriverActivationStatus>))]
[Serializable]
public readonly record struct DriverActivationStatus : IStringEnum
{
    public static readonly DriverActivationStatus Active = new(Values.Active);

    public static readonly DriverActivationStatus Deactivated = new(Values.Deactivated);

    public DriverActivationStatus(string value)
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
    public static DriverActivationStatus FromCustom(string value)
    {
        return new DriverActivationStatus(value);
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

    public static bool operator ==(DriverActivationStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DriverActivationStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DriverActivationStatus value) => value.Value;

    public static explicit operator DriverActivationStatus(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Active = "active";

        public const string Deactivated = "deactivated";
    }
}
