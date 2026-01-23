using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<VehicleSensorConfigurationAreaPosition>))]
[Serializable]
public readonly record struct VehicleSensorConfigurationAreaPosition : IStringEnum
{
    public static readonly VehicleSensorConfigurationAreaPosition PositionFront = new(
        Values.PositionFront
    );

    public static readonly VehicleSensorConfigurationAreaPosition PositionMiddle = new(
        Values.PositionMiddle
    );

    public static readonly VehicleSensorConfigurationAreaPosition PositionBack = new(
        Values.PositionBack
    );

    public VehicleSensorConfigurationAreaPosition(string value)
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
    public static VehicleSensorConfigurationAreaPosition FromCustom(string value)
    {
        return new VehicleSensorConfigurationAreaPosition(value);
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

    public static bool operator ==(VehicleSensorConfigurationAreaPosition value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(VehicleSensorConfigurationAreaPosition value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(VehicleSensorConfigurationAreaPosition value) =>
        value.Value;

    public static explicit operator VehicleSensorConfigurationAreaPosition(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string PositionFront = "Position_Front";

        public const string PositionMiddle = "Position_Middle";

        public const string PositionBack = "Position_Back";
    }
}
