using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<PreferredStationDiscountInputRequestBodyVolumeUnit>))]
[Serializable]
public readonly record struct PreferredStationDiscountInputRequestBodyVolumeUnit : IStringEnum
{
    public static readonly PreferredStationDiscountInputRequestBodyVolumeUnit Liter = new(
        Values.Liter
    );

    public static readonly PreferredStationDiscountInputRequestBodyVolumeUnit Gallon = new(
        Values.Gallon
    );

    public static readonly PreferredStationDiscountInputRequestBodyVolumeUnit ImperialGallon = new(
        Values.ImperialGallon
    );

    public PreferredStationDiscountInputRequestBodyVolumeUnit(string value)
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
    public static PreferredStationDiscountInputRequestBodyVolumeUnit FromCustom(string value)
    {
        return new PreferredStationDiscountInputRequestBodyVolumeUnit(value);
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
        PreferredStationDiscountInputRequestBodyVolumeUnit value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PreferredStationDiscountInputRequestBodyVolumeUnit value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PreferredStationDiscountInputRequestBodyVolumeUnit value
    ) => value.Value;

    public static explicit operator PreferredStationDiscountInputRequestBodyVolumeUnit(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Liter = "liter";

        public const string Gallon = "gallon";

        public const string ImperialGallon = "imperialGallon";
    }
}
