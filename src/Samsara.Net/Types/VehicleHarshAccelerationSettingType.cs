using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<VehicleHarshAccelerationSettingType>))]
[Serializable]
public readonly record struct VehicleHarshAccelerationSettingType : IStringEnum
{
    public static readonly VehicleHarshAccelerationSettingType PassengerCar = new(
        Values.PassengerCar
    );

    public static readonly VehicleHarshAccelerationSettingType LightTruck = new(Values.LightTruck);

    public static readonly VehicleHarshAccelerationSettingType HeavyDuty = new(Values.HeavyDuty);

    public static readonly VehicleHarshAccelerationSettingType Off = new(Values.Off);

    public static readonly VehicleHarshAccelerationSettingType Automatic = new(Values.Automatic);

    public VehicleHarshAccelerationSettingType(string value)
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
    public static VehicleHarshAccelerationSettingType FromCustom(string value)
    {
        return new VehicleHarshAccelerationSettingType(value);
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

    public static bool operator ==(VehicleHarshAccelerationSettingType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(VehicleHarshAccelerationSettingType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(VehicleHarshAccelerationSettingType value) =>
        value.Value;

    public static explicit operator VehicleHarshAccelerationSettingType(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string PassengerCar = "passengerCar";

        public const string LightTruck = "lightTruck";

        public const string HeavyDuty = "heavyDuty";

        public const string Off = "off";

        public const string Automatic = "automatic";
    }
}
