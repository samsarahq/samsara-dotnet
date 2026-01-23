using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<GrossVehicleWeightUnit>))]
[Serializable]
public readonly record struct GrossVehicleWeightUnit : IStringEnum
{
    public static readonly GrossVehicleWeightUnit Lb = new(Values.Lb);

    public static readonly GrossVehicleWeightUnit Kg = new(Values.Kg);

    public GrossVehicleWeightUnit(string value)
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
    public static GrossVehicleWeightUnit FromCustom(string value)
    {
        return new GrossVehicleWeightUnit(value);
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

    public static bool operator ==(GrossVehicleWeightUnit value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(GrossVehicleWeightUnit value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(GrossVehicleWeightUnit value) => value.Value;

    public static explicit operator GrossVehicleWeightUnit(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Lb = "lb";

        public const string Kg = "kg";
    }
}
