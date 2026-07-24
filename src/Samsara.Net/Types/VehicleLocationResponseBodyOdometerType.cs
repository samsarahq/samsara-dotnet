using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<VehicleLocationResponseBodyOdometerType>))]
[Serializable]
public readonly record struct VehicleLocationResponseBodyOdometerType : IStringEnum
{
    public static readonly VehicleLocationResponseBodyOdometerType Gps = new(Values.Gps);

    public static readonly VehicleLocationResponseBodyOdometerType Obd = new(Values.Obd);

    public VehicleLocationResponseBodyOdometerType(string value)
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
    public static VehicleLocationResponseBodyOdometerType FromCustom(string value)
    {
        return new VehicleLocationResponseBodyOdometerType(value);
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

    public static bool operator ==(VehicleLocationResponseBodyOdometerType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(VehicleLocationResponseBodyOdometerType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(VehicleLocationResponseBodyOdometerType value) =>
        value.Value;

    public static explicit operator VehicleLocationResponseBodyOdometerType(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Gps = "GPS";

        public const string Obd = "OBD";
    }
}
