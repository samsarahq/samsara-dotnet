using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.DriverVehicleAssignments;

[JsonConverter(typeof(StringEnumSerializer<GetDriverVehicleAssignmentsRequestFilterBy>))]
[Serializable]
public readonly record struct GetDriverVehicleAssignmentsRequestFilterBy : IStringEnum
{
    public static readonly GetDriverVehicleAssignmentsRequestFilterBy Drivers = new(Values.Drivers);

    public static readonly GetDriverVehicleAssignmentsRequestFilterBy Vehicles = new(
        Values.Vehicles
    );

    public GetDriverVehicleAssignmentsRequestFilterBy(string value)
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
    public static GetDriverVehicleAssignmentsRequestFilterBy FromCustom(string value)
    {
        return new GetDriverVehicleAssignmentsRequestFilterBy(value);
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
        GetDriverVehicleAssignmentsRequestFilterBy value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        GetDriverVehicleAssignmentsRequestFilterBy value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(GetDriverVehicleAssignmentsRequestFilterBy value) =>
        value.Value;

    public static explicit operator GetDriverVehicleAssignmentsRequestFilterBy(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Drivers = "drivers";

        public const string Vehicles = "vehicles";
    }
}
