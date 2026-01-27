using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<VehicleResponseObjectResponseBodyVehicleRegulationMode>)
)]
[Serializable]
public readonly record struct VehicleResponseObjectResponseBodyVehicleRegulationMode : IStringEnum
{
    public static readonly VehicleResponseObjectResponseBodyVehicleRegulationMode Regulated = new(
        Values.Regulated
    );

    public static readonly VehicleResponseObjectResponseBodyVehicleRegulationMode Unregulated = new(
        Values.Unregulated
    );

    public VehicleResponseObjectResponseBodyVehicleRegulationMode(string value)
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
    public static VehicleResponseObjectResponseBodyVehicleRegulationMode FromCustom(string value)
    {
        return new VehicleResponseObjectResponseBodyVehicleRegulationMode(value);
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
        VehicleResponseObjectResponseBodyVehicleRegulationMode value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        VehicleResponseObjectResponseBodyVehicleRegulationMode value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        VehicleResponseObjectResponseBodyVehicleRegulationMode value
    ) => value.Value;

    public static explicit operator VehicleResponseObjectResponseBodyVehicleRegulationMode(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Regulated = "regulated";

        public const string Unregulated = "unregulated";
    }
}
