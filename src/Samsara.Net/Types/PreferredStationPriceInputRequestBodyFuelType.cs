using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<PreferredStationPriceInputRequestBodyFuelType>))]
[Serializable]
public readonly record struct PreferredStationPriceInputRequestBodyFuelType : IStringEnum
{
    public static readonly PreferredStationPriceInputRequestBodyFuelType Gasoline = new(
        Values.Gasoline
    );

    public static readonly PreferredStationPriceInputRequestBodyFuelType Diesel = new(
        Values.Diesel
    );

    public static readonly PreferredStationPriceInputRequestBodyFuelType Biodiesel = new(
        Values.Biodiesel
    );

    public static readonly PreferredStationPriceInputRequestBodyFuelType FlexibleFuelE85 = new(
        Values.FlexibleFuelE85
    );

    public static readonly PreferredStationPriceInputRequestBodyFuelType EthanolE100 = new(
        Values.EthanolE100
    );

    public static readonly PreferredStationPriceInputRequestBodyFuelType RenewableDiesel = new(
        Values.RenewableDiesel
    );

    public static readonly PreferredStationPriceInputRequestBodyFuelType M100 = new(Values.M100);

    public static readonly PreferredStationPriceInputRequestBodyFuelType Cng = new(Values.Cng);

    public static readonly PreferredStationPriceInputRequestBodyFuelType Lng = new(Values.Lng);

    public static readonly PreferredStationPriceInputRequestBodyFuelType Lpg = new(Values.Lpg);

    public static readonly PreferredStationPriceInputRequestBodyFuelType Rng = new(Values.Rng);

    public static readonly PreferredStationPriceInputRequestBodyFuelType Fcev = new(Values.Fcev);

    public static readonly PreferredStationPriceInputRequestBodyFuelType Unknown = new(
        Values.Unknown
    );

    public PreferredStationPriceInputRequestBodyFuelType(string value)
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
    public static PreferredStationPriceInputRequestBodyFuelType FromCustom(string value)
    {
        return new PreferredStationPriceInputRequestBodyFuelType(value);
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
        PreferredStationPriceInputRequestBodyFuelType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PreferredStationPriceInputRequestBodyFuelType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PreferredStationPriceInputRequestBodyFuelType value) =>
        value.Value;

    public static explicit operator PreferredStationPriceInputRequestBodyFuelType(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Gasoline = "gasoline";

        public const string Diesel = "diesel";

        public const string Biodiesel = "biodiesel";

        public const string FlexibleFuelE85 = "flexibleFuelE85";

        public const string EthanolE100 = "ethanolE100";

        public const string RenewableDiesel = "renewableDiesel";

        public const string M100 = "m100";

        public const string Cng = "cng";

        public const string Lng = "lng";

        public const string Lpg = "lpg";

        public const string Rng = "rng";

        public const string Fcev = "fcev";

        public const string Unknown = "unknown";
    }
}
