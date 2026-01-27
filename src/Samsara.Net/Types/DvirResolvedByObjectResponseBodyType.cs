using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<DvirResolvedByObjectResponseBodyType>))]
[Serializable]
public readonly record struct DvirResolvedByObjectResponseBodyType : IStringEnum
{
    public static readonly DvirResolvedByObjectResponseBodyType Driver = new(Values.Driver);

    public static readonly DvirResolvedByObjectResponseBodyType Mechanic = new(Values.Mechanic);

    public DvirResolvedByObjectResponseBodyType(string value)
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
    public static DvirResolvedByObjectResponseBodyType FromCustom(string value)
    {
        return new DvirResolvedByObjectResponseBodyType(value);
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

    public static bool operator ==(DvirResolvedByObjectResponseBodyType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DvirResolvedByObjectResponseBodyType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DvirResolvedByObjectResponseBodyType value) =>
        value.Value;

    public static explicit operator DvirResolvedByObjectResponseBodyType(string value) =>
        new(value);

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
