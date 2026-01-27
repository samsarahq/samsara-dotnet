using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<VehicleSensorConfigurationAreaResponseBodyPosition>))]
[Serializable]
public readonly record struct VehicleSensorConfigurationAreaResponseBodyPosition : IStringEnum
{
    public static readonly VehicleSensorConfigurationAreaResponseBodyPosition Back = new(
        Values.Back
    );

    public static readonly VehicleSensorConfigurationAreaResponseBodyPosition Front = new(
        Values.Front
    );

    public static readonly VehicleSensorConfigurationAreaResponseBodyPosition Middle = new(
        Values.Middle
    );

    public VehicleSensorConfigurationAreaResponseBodyPosition(string value)
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
    public static VehicleSensorConfigurationAreaResponseBodyPosition FromCustom(string value)
    {
        return new VehicleSensorConfigurationAreaResponseBodyPosition(value);
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
        VehicleSensorConfigurationAreaResponseBodyPosition value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        VehicleSensorConfigurationAreaResponseBodyPosition value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        VehicleSensorConfigurationAreaResponseBodyPosition value
    ) => value.Value;

    public static explicit operator VehicleSensorConfigurationAreaResponseBodyPosition(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Back = "back";

        public const string Front = "front";

        public const string Middle = "middle";
    }
}
