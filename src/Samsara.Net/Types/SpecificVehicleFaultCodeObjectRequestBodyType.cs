using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<SpecificVehicleFaultCodeObjectRequestBodyType>))]
[Serializable]
public readonly record struct SpecificVehicleFaultCodeObjectRequestBodyType : IStringEnum
{
    public static readonly SpecificVehicleFaultCodeObjectRequestBodyType InvalidFaultCodeType = new(
        Values.InvalidFaultCodeType
    );

    public static readonly SpecificVehicleFaultCodeObjectRequestBodyType J1939Dtc = new(
        Values.J1939Dtc
    );

    public static readonly SpecificVehicleFaultCodeObjectRequestBodyType J1939Spn = new(
        Values.J1939Spn
    );

    public static readonly SpecificVehicleFaultCodeObjectRequestBodyType PassengerDtc = new(
        Values.PassengerDtc
    );

    public SpecificVehicleFaultCodeObjectRequestBodyType(string value)
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
    public static SpecificVehicleFaultCodeObjectRequestBodyType FromCustom(string value)
    {
        return new SpecificVehicleFaultCodeObjectRequestBodyType(value);
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
        SpecificVehicleFaultCodeObjectRequestBodyType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        SpecificVehicleFaultCodeObjectRequestBodyType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(SpecificVehicleFaultCodeObjectRequestBodyType value) =>
        value.Value;

    public static explicit operator SpecificVehicleFaultCodeObjectRequestBodyType(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string InvalidFaultCodeType = "INVALID_FAULT_CODE_TYPE";

        public const string J1939Dtc = "J1939_DTC";

        public const string J1939Spn = "J1939_SPN";

        public const string PassengerDtc = "PASSENGER_DTC";
    }
}
