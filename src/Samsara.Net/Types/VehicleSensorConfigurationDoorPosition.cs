using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<VehicleSensorConfigurationDoorPosition>))]
[Serializable]
public readonly record struct VehicleSensorConfigurationDoorPosition : IStringEnum
{
    public static readonly VehicleSensorConfigurationDoorPosition PositionLeft = new(
        Values.PositionLeft
    );

    public static readonly VehicleSensorConfigurationDoorPosition PositionRight = new(
        Values.PositionRight
    );

    public VehicleSensorConfigurationDoorPosition(string value)
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
    public static VehicleSensorConfigurationDoorPosition FromCustom(string value)
    {
        return new VehicleSensorConfigurationDoorPosition(value);
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

    public static bool operator ==(VehicleSensorConfigurationDoorPosition value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(VehicleSensorConfigurationDoorPosition value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(VehicleSensorConfigurationDoorPosition value) =>
        value.Value;

    public static explicit operator VehicleSensorConfigurationDoorPosition(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string PositionLeft = "Position_Left";

        public const string PositionRight = "Position_Right";
    }
}
