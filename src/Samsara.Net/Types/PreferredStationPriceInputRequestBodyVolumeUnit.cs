using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<PreferredStationPriceInputRequestBodyVolumeUnit>))]
[Serializable]
public readonly record struct PreferredStationPriceInputRequestBodyVolumeUnit : IStringEnum
{
    public static readonly PreferredStationPriceInputRequestBodyVolumeUnit Liter = new(
        Values.Liter
    );

    public static readonly PreferredStationPriceInputRequestBodyVolumeUnit Gallon = new(
        Values.Gallon
    );

    public static readonly PreferredStationPriceInputRequestBodyVolumeUnit ImperialGallon = new(
        Values.ImperialGallon
    );

    public PreferredStationPriceInputRequestBodyVolumeUnit(string value)
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
    public static PreferredStationPriceInputRequestBodyVolumeUnit FromCustom(string value)
    {
        return new PreferredStationPriceInputRequestBodyVolumeUnit(value);
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
        PreferredStationPriceInputRequestBodyVolumeUnit value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PreferredStationPriceInputRequestBodyVolumeUnit value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PreferredStationPriceInputRequestBodyVolumeUnit value) =>
        value.Value;

    public static explicit operator PreferredStationPriceInputRequestBodyVolumeUnit(string value) =>
        new(value);

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
