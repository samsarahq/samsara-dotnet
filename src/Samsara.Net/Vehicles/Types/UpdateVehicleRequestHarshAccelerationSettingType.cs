using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Vehicles;

[JsonConverter(typeof(StringEnumSerializer<UpdateVehicleRequestHarshAccelerationSettingType>))]
[Serializable]
public readonly record struct UpdateVehicleRequestHarshAccelerationSettingType : IStringEnum
{
    public static readonly UpdateVehicleRequestHarshAccelerationSettingType PassengerCar = new(
        Values.PassengerCar
    );

    public static readonly UpdateVehicleRequestHarshAccelerationSettingType LightTruck = new(
        Values.LightTruck
    );

    public static readonly UpdateVehicleRequestHarshAccelerationSettingType HeavyDuty = new(
        Values.HeavyDuty
    );

    public static readonly UpdateVehicleRequestHarshAccelerationSettingType Off = new(Values.Off);

    public static readonly UpdateVehicleRequestHarshAccelerationSettingType Automatic = new(
        Values.Automatic
    );

    public UpdateVehicleRequestHarshAccelerationSettingType(string value)
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
    public static UpdateVehicleRequestHarshAccelerationSettingType FromCustom(string value)
    {
        return new UpdateVehicleRequestHarshAccelerationSettingType(value);
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
        UpdateVehicleRequestHarshAccelerationSettingType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        UpdateVehicleRequestHarshAccelerationSettingType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        UpdateVehicleRequestHarshAccelerationSettingType value
    ) => value.Value;

    public static explicit operator UpdateVehicleRequestHarshAccelerationSettingType(
        string value
    ) => new(value);

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
