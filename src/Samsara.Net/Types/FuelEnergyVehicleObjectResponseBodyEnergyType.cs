using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<FuelEnergyVehicleObjectResponseBodyEnergyType>))]
[Serializable]
public readonly record struct FuelEnergyVehicleObjectResponseBodyEnergyType : IStringEnum
{
    public static readonly FuelEnergyVehicleObjectResponseBodyEnergyType Fuel = new(Values.Fuel);

    public static readonly FuelEnergyVehicleObjectResponseBodyEnergyType Hybrid = new(
        Values.Hybrid
    );

    public static readonly FuelEnergyVehicleObjectResponseBodyEnergyType Electric = new(
        Values.Electric
    );

    public FuelEnergyVehicleObjectResponseBodyEnergyType(string value)
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
    public static FuelEnergyVehicleObjectResponseBodyEnergyType FromCustom(string value)
    {
        return new FuelEnergyVehicleObjectResponseBodyEnergyType(value);
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
        FuelEnergyVehicleObjectResponseBodyEnergyType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        FuelEnergyVehicleObjectResponseBodyEnergyType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(FuelEnergyVehicleObjectResponseBodyEnergyType value) =>
        value.Value;

    public static explicit operator FuelEnergyVehicleObjectResponseBodyEnergyType(string value) =>
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
