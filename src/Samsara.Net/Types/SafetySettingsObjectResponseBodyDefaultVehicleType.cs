using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<SafetySettingsObjectResponseBodyDefaultVehicleType>))]
[Serializable]
public readonly record struct SafetySettingsObjectResponseBodyDefaultVehicleType : IStringEnum
{
    public static readonly SafetySettingsObjectResponseBodyDefaultVehicleType Off = new(Values.Off);

    public static readonly SafetySettingsObjectResponseBodyDefaultVehicleType Automatic = new(
        Values.Automatic
    );

    public static readonly SafetySettingsObjectResponseBodyDefaultVehicleType PassengerCar = new(
        Values.PassengerCar
    );

    public static readonly SafetySettingsObjectResponseBodyDefaultVehicleType LightTruck = new(
        Values.LightTruck
    );

    public static readonly SafetySettingsObjectResponseBodyDefaultVehicleType HeavyDuty = new(
        Values.HeavyDuty
    );

    public SafetySettingsObjectResponseBodyDefaultVehicleType(string value)
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
    public static SafetySettingsObjectResponseBodyDefaultVehicleType FromCustom(string value)
    {
        return new SafetySettingsObjectResponseBodyDefaultVehicleType(value);
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
        SafetySettingsObjectResponseBodyDefaultVehicleType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        SafetySettingsObjectResponseBodyDefaultVehicleType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        SafetySettingsObjectResponseBodyDefaultVehicleType value
    ) => value.Value;

    public static explicit operator SafetySettingsObjectResponseBodyDefaultVehicleType(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Off = "off";

        public const string Automatic = "automatic";

        public const string PassengerCar = "passengerCar";

        public const string LightTruck = "lightTruck";

        public const string HeavyDuty = "heavyDuty";
    }
}
