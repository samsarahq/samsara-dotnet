using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<VehicleResponseObjectResponseBodyVehicleType>))]
[Serializable]
public readonly record struct VehicleResponseObjectResponseBodyVehicleType : IStringEnum
{
    public static readonly VehicleResponseObjectResponseBodyVehicleType Unset = new(Values.Unset);

    public static readonly VehicleResponseObjectResponseBodyVehicleType Passenger = new(
        Values.Passenger
    );

    public static readonly VehicleResponseObjectResponseBodyVehicleType Truck = new(Values.Truck);

    public static readonly VehicleResponseObjectResponseBodyVehicleType Bus = new(Values.Bus);

    public VehicleResponseObjectResponseBodyVehicleType(string value)
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
    public static VehicleResponseObjectResponseBodyVehicleType FromCustom(string value)
    {
        return new VehicleResponseObjectResponseBodyVehicleType(value);
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
        VehicleResponseObjectResponseBodyVehicleType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        VehicleResponseObjectResponseBodyVehicleType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(VehicleResponseObjectResponseBodyVehicleType value) =>
        value.Value;

    public static explicit operator VehicleResponseObjectResponseBodyVehicleType(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Unset = "unset";

        public const string Passenger = "passenger";

        public const string Truck = "truck";

        public const string Bus = "bus";
    }
}
