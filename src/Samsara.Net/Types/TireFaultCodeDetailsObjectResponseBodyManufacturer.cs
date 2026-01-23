using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<TireFaultCodeDetailsObjectResponseBodyManufacturer>))]
[Serializable]
public readonly record struct TireFaultCodeDetailsObjectResponseBodyManufacturer : IStringEnum
{
    public static readonly TireFaultCodeDetailsObjectResponseBodyManufacturer ManufacturerBendix =
        new(Values.ManufacturerBendix);

    public static readonly TireFaultCodeDetailsObjectResponseBodyManufacturer ManufacturerContinental =
        new(Values.ManufacturerContinental);

    public static readonly TireFaultCodeDetailsObjectResponseBodyManufacturer ManufacturerDoran =
        new(Values.ManufacturerDoran);

    public static readonly TireFaultCodeDetailsObjectResponseBodyManufacturer ManufacturerHendrickson =
        new(Values.ManufacturerHendrickson);

    public static readonly TireFaultCodeDetailsObjectResponseBodyManufacturer ManufacturerInvalid =
        new(Values.ManufacturerInvalid);

    public static readonly TireFaultCodeDetailsObjectResponseBodyManufacturer ManufacturerPressurePro =
        new(Values.ManufacturerPressurePro);

    public static readonly TireFaultCodeDetailsObjectResponseBodyManufacturer ManufacturerUniversalJ1939 =
        new(Values.ManufacturerUniversalJ1939);

    public static readonly TireFaultCodeDetailsObjectResponseBodyManufacturer ManufacturerUniversalR141 =
        new(Values.ManufacturerUniversalR141);

    public TireFaultCodeDetailsObjectResponseBodyManufacturer(string value)
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
    public static TireFaultCodeDetailsObjectResponseBodyManufacturer FromCustom(string value)
    {
        return new TireFaultCodeDetailsObjectResponseBodyManufacturer(value);
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
        TireFaultCodeDetailsObjectResponseBodyManufacturer value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        TireFaultCodeDetailsObjectResponseBodyManufacturer value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        TireFaultCodeDetailsObjectResponseBodyManufacturer value
    ) => value.Value;

    public static explicit operator TireFaultCodeDetailsObjectResponseBodyManufacturer(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string ManufacturerBendix = "MANUFACTURER_BENDIX";

        public const string ManufacturerContinental = "MANUFACTURER_CONTINENTAL";

        public const string ManufacturerDoran = "MANUFACTURER_DORAN";

        public const string ManufacturerHendrickson = "MANUFACTURER_HENDRICKSON";

        public const string ManufacturerInvalid = "MANUFACTURER_INVALID";

        public const string ManufacturerPressurePro = "MANUFACTURER_PRESSURE_PRO";

        public const string ManufacturerUniversalJ1939 = "MANUFACTURER_UNIVERSAL_J1939";

        public const string ManufacturerUniversalR141 = "MANUFACTURER_UNIVERSAL_R141";
    }
}
