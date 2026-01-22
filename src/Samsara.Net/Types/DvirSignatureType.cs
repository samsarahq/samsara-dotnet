using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<DvirSignatureType>))]
[Serializable]
public readonly record struct DvirSignatureType : IStringEnum
{
    public static readonly DvirSignatureType Driver = new(Values.Driver);

    public static readonly DvirSignatureType Mechanic = new(Values.Mechanic);

    public DvirSignatureType(string value)
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
    public static DvirSignatureType FromCustom(string value)
    {
        return new DvirSignatureType(value);
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

    public static bool operator ==(DvirSignatureType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DvirSignatureType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DvirSignatureType value) => value.Value;

    public static explicit operator DvirSignatureType(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Driver = "driver";

        public const string Mechanic = "mechanic";
    }
}
