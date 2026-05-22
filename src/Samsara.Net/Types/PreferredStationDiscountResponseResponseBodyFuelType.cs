using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<PreferredStationDiscountResponseResponseBodyFuelType>))]
[Serializable]
public readonly record struct PreferredStationDiscountResponseResponseBodyFuelType : IStringEnum
{
    public static readonly PreferredStationDiscountResponseResponseBodyFuelType Gasoline = new(
        Values.Gasoline
    );

    public static readonly PreferredStationDiscountResponseResponseBodyFuelType Diesel = new(
        Values.Diesel
    );

    public static readonly PreferredStationDiscountResponseResponseBodyFuelType Biodiesel = new(
        Values.Biodiesel
    );

    public static readonly PreferredStationDiscountResponseResponseBodyFuelType FlexibleFuelE85 =
        new(Values.FlexibleFuelE85);

    public static readonly PreferredStationDiscountResponseResponseBodyFuelType Electricity = new(
        Values.Electricity
    );

    public static readonly PreferredStationDiscountResponseResponseBodyFuelType EthanolE100 = new(
        Values.EthanolE100
    );

    public static readonly PreferredStationDiscountResponseResponseBodyFuelType RenewableDiesel =
        new(Values.RenewableDiesel);

    public static readonly PreferredStationDiscountResponseResponseBodyFuelType M100 = new(
        Values.M100
    );

    public static readonly PreferredStationDiscountResponseResponseBodyFuelType Cng = new(
        Values.Cng
    );

    public static readonly PreferredStationDiscountResponseResponseBodyFuelType Lng = new(
        Values.Lng
    );

    public static readonly PreferredStationDiscountResponseResponseBodyFuelType Lpg = new(
        Values.Lpg
    );

    public static readonly PreferredStationDiscountResponseResponseBodyFuelType Rng = new(
        Values.Rng
    );

    public static readonly PreferredStationDiscountResponseResponseBodyFuelType Fcev = new(
        Values.Fcev
    );

    public static readonly PreferredStationDiscountResponseResponseBodyFuelType Unknown = new(
        Values.Unknown
    );

    public PreferredStationDiscountResponseResponseBodyFuelType(string value)
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
    public static PreferredStationDiscountResponseResponseBodyFuelType FromCustom(string value)
    {
        return new PreferredStationDiscountResponseResponseBodyFuelType(value);
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
        PreferredStationDiscountResponseResponseBodyFuelType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PreferredStationDiscountResponseResponseBodyFuelType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PreferredStationDiscountResponseResponseBodyFuelType value
    ) => value.Value;

    public static explicit operator PreferredStationDiscountResponseResponseBodyFuelType(
        string value
    ) => new(value);

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

        public const string Electricity = "electricity";

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
