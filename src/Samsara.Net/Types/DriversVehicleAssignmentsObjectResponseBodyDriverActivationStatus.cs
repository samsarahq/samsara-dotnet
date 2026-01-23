using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<DriversVehicleAssignmentsObjectResponseBodyDriverActivationStatus>)
)]
[Serializable]
public readonly record struct DriversVehicleAssignmentsObjectResponseBodyDriverActivationStatus
    : IStringEnum
{
    public static readonly DriversVehicleAssignmentsObjectResponseBodyDriverActivationStatus Active =
        new(Values.Active);

    public static readonly DriversVehicleAssignmentsObjectResponseBodyDriverActivationStatus Deactivated =
        new(Values.Deactivated);

    public DriversVehicleAssignmentsObjectResponseBodyDriverActivationStatus(string value)
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
    public static DriversVehicleAssignmentsObjectResponseBodyDriverActivationStatus FromCustom(
        string value
    )
    {
        return new DriversVehicleAssignmentsObjectResponseBodyDriverActivationStatus(value);
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
        DriversVehicleAssignmentsObjectResponseBodyDriverActivationStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DriversVehicleAssignmentsObjectResponseBodyDriverActivationStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DriversVehicleAssignmentsObjectResponseBodyDriverActivationStatus value
    ) => value.Value;

    public static explicit operator DriversVehicleAssignmentsObjectResponseBodyDriverActivationStatus(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Active = "active";

        public const string Deactivated = "deactivated";
    }
}
