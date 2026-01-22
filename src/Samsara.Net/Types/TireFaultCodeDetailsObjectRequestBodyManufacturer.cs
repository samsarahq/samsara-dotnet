using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<TireFaultCodeDetailsObjectRequestBodyManufacturer>))]
[Serializable]
public readonly record struct TireFaultCodeDetailsObjectRequestBodyManufacturer : IStringEnum
{
    public static readonly TireFaultCodeDetailsObjectRequestBodyManufacturer ManufacturerBendix =
        new(Values.ManufacturerBendix);

    public static readonly TireFaultCodeDetailsObjectRequestBodyManufacturer ManufacturerContinental =
        new(Values.ManufacturerContinental);

    public static readonly TireFaultCodeDetailsObjectRequestBodyManufacturer ManufacturerDoran =
        new(Values.ManufacturerDoran);

    public static readonly TireFaultCodeDetailsObjectRequestBodyManufacturer ManufacturerHendrickson =
        new(Values.ManufacturerHendrickson);

    public static readonly TireFaultCodeDetailsObjectRequestBodyManufacturer ManufacturerInvalid =
        new(Values.ManufacturerInvalid);

    public static readonly TireFaultCodeDetailsObjectRequestBodyManufacturer ManufacturerPressurePro =
        new(Values.ManufacturerPressurePro);

    public static readonly TireFaultCodeDetailsObjectRequestBodyManufacturer ManufacturerUniversalJ1939 =
        new(Values.ManufacturerUniversalJ1939);

    public static readonly TireFaultCodeDetailsObjectRequestBodyManufacturer ManufacturerUniversalR141 =
        new(Values.ManufacturerUniversalR141);

    public TireFaultCodeDetailsObjectRequestBodyManufacturer(string value)
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
    public static TireFaultCodeDetailsObjectRequestBodyManufacturer FromCustom(string value)
    {
        return new TireFaultCodeDetailsObjectRequestBodyManufacturer(value);
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
        TireFaultCodeDetailsObjectRequestBodyManufacturer value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        TireFaultCodeDetailsObjectRequestBodyManufacturer value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        TireFaultCodeDetailsObjectRequestBodyManufacturer value
    ) => value.Value;

    public static explicit operator TireFaultCodeDetailsObjectRequestBodyManufacturer(
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
