using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.LegacyApis;

[JsonConverter(
    typeof(StringEnumSerializer<GetDriversVehicleAssignmentsRequestDriverActivationStatus>)
)]
[Serializable]
public readonly record struct GetDriversVehicleAssignmentsRequestDriverActivationStatus
    : IStringEnum
{
    public static readonly GetDriversVehicleAssignmentsRequestDriverActivationStatus Active = new(
        Values.Active
    );

    public static readonly GetDriversVehicleAssignmentsRequestDriverActivationStatus Deactivated =
        new(Values.Deactivated);

    public GetDriversVehicleAssignmentsRequestDriverActivationStatus(string value)
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
    public static GetDriversVehicleAssignmentsRequestDriverActivationStatus FromCustom(string value)
    {
        return new GetDriversVehicleAssignmentsRequestDriverActivationStatus(value);
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
        GetDriversVehicleAssignmentsRequestDriverActivationStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        GetDriversVehicleAssignmentsRequestDriverActivationStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        GetDriversVehicleAssignmentsRequestDriverActivationStatus value
    ) => value.Value;

    public static explicit operator GetDriversVehicleAssignmentsRequestDriverActivationStatus(
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
