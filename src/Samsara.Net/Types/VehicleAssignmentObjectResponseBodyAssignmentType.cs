using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<VehicleAssignmentObjectResponseBodyAssignmentType>))]
[Serializable]
public readonly record struct VehicleAssignmentObjectResponseBodyAssignmentType : IStringEnum
{
    public static readonly VehicleAssignmentObjectResponseBodyAssignmentType DriverApp = new(
        Values.DriverApp
    );

    public VehicleAssignmentObjectResponseBodyAssignmentType(string value)
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
    public static VehicleAssignmentObjectResponseBodyAssignmentType FromCustom(string value)
    {
        return new VehicleAssignmentObjectResponseBodyAssignmentType(value);
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
        VehicleAssignmentObjectResponseBodyAssignmentType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        VehicleAssignmentObjectResponseBodyAssignmentType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        VehicleAssignmentObjectResponseBodyAssignmentType value
    ) => value.Value;

    public static explicit operator VehicleAssignmentObjectResponseBodyAssignmentType(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string DriverApp = "driverApp";
    }
}
