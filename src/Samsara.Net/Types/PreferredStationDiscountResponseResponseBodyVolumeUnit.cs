using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<PreferredStationDiscountResponseResponseBodyVolumeUnit>)
)]
[Serializable]
public readonly record struct PreferredStationDiscountResponseResponseBodyVolumeUnit : IStringEnum
{
    public static readonly PreferredStationDiscountResponseResponseBodyVolumeUnit Liter = new(
        Values.Liter
    );

    public static readonly PreferredStationDiscountResponseResponseBodyVolumeUnit Gallon = new(
        Values.Gallon
    );

    public static readonly PreferredStationDiscountResponseResponseBodyVolumeUnit ImperialGallon =
        new(Values.ImperialGallon);

    public static readonly PreferredStationDiscountResponseResponseBodyVolumeUnit Unknown = new(
        Values.Unknown
    );

    public PreferredStationDiscountResponseResponseBodyVolumeUnit(string value)
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
    public static PreferredStationDiscountResponseResponseBodyVolumeUnit FromCustom(string value)
    {
        return new PreferredStationDiscountResponseResponseBodyVolumeUnit(value);
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
        PreferredStationDiscountResponseResponseBodyVolumeUnit value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PreferredStationDiscountResponseResponseBodyVolumeUnit value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PreferredStationDiscountResponseResponseBodyVolumeUnit value
    ) => value.Value;

    public static explicit operator PreferredStationDiscountResponseResponseBodyVolumeUnit(
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

        public const string Unknown = "unknown";
    }
}
