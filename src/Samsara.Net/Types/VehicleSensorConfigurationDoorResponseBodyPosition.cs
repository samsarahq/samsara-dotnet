using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<VehicleSensorConfigurationDoorResponseBodyPosition>))]
[Serializable]
public readonly record struct VehicleSensorConfigurationDoorResponseBodyPosition : IStringEnum
{
    public static readonly VehicleSensorConfigurationDoorResponseBodyPosition Back = new(
        Values.Back
    );

    public static readonly VehicleSensorConfigurationDoorResponseBodyPosition Left = new(
        Values.Left
    );

    public static readonly VehicleSensorConfigurationDoorResponseBodyPosition Right = new(
        Values.Right
    );

    public VehicleSensorConfigurationDoorResponseBodyPosition(string value)
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
    public static VehicleSensorConfigurationDoorResponseBodyPosition FromCustom(string value)
    {
        return new VehicleSensorConfigurationDoorResponseBodyPosition(value);
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
        VehicleSensorConfigurationDoorResponseBodyPosition value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        VehicleSensorConfigurationDoorResponseBodyPosition value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        VehicleSensorConfigurationDoorResponseBodyPosition value
    ) => value.Value;

    public static explicit operator VehicleSensorConfigurationDoorResponseBodyPosition(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Back = "back";

        public const string Left = "left";

        public const string Right = "right";
    }
}
