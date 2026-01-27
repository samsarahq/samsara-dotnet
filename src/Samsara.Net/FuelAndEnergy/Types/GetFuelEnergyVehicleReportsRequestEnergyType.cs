using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.FuelAndEnergy;

[JsonConverter(typeof(StringEnumSerializer<GetFuelEnergyVehicleReportsRequestEnergyType>))]
[Serializable]
public readonly record struct GetFuelEnergyVehicleReportsRequestEnergyType : IStringEnum
{
    public static readonly GetFuelEnergyVehicleReportsRequestEnergyType Fuel = new(Values.Fuel);

    public static readonly GetFuelEnergyVehicleReportsRequestEnergyType Hybrid = new(Values.Hybrid);

    public static readonly GetFuelEnergyVehicleReportsRequestEnergyType Electric = new(
        Values.Electric
    );

    public GetFuelEnergyVehicleReportsRequestEnergyType(string value)
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
    public static GetFuelEnergyVehicleReportsRequestEnergyType FromCustom(string value)
    {
        return new GetFuelEnergyVehicleReportsRequestEnergyType(value);
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
        GetFuelEnergyVehicleReportsRequestEnergyType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        GetFuelEnergyVehicleReportsRequestEnergyType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(GetFuelEnergyVehicleReportsRequestEnergyType value) =>
        value.Value;

    public static explicit operator GetFuelEnergyVehicleReportsRequestEnergyType(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Fuel = "fuel";

        public const string Hybrid = "hybrid";

        public const string Electric = "electric";
    }
}
