using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<FuelVolumeResponseBodyUnit>))]
[Serializable]
public readonly record struct FuelVolumeResponseBodyUnit : IStringEnum
{
    public static readonly FuelVolumeResponseBodyUnit Gallons = new(Values.Gallons);

    public static readonly FuelVolumeResponseBodyUnit Liters = new(Values.Liters);

    public FuelVolumeResponseBodyUnit(string value)
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
    public static FuelVolumeResponseBodyUnit FromCustom(string value)
    {
        return new FuelVolumeResponseBodyUnit(value);
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

    public static bool operator ==(FuelVolumeResponseBodyUnit value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(FuelVolumeResponseBodyUnit value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(FuelVolumeResponseBodyUnit value) => value.Value;

    public static explicit operator FuelVolumeResponseBodyUnit(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Gallons = "GALLONS";

        public const string Liters = "LITERS";
    }
}
