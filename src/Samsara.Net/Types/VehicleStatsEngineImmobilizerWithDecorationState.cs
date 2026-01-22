using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<VehicleStatsEngineImmobilizerWithDecorationState>))]
[Serializable]
public readonly record struct VehicleStatsEngineImmobilizerWithDecorationState : IStringEnum
{
    public static readonly VehicleStatsEngineImmobilizerWithDecorationState IgnitionDisabled = new(
        Values.IgnitionDisabled
    );

    public static readonly VehicleStatsEngineImmobilizerWithDecorationState IgnitionEnabled = new(
        Values.IgnitionEnabled
    );

    public VehicleStatsEngineImmobilizerWithDecorationState(string value)
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
    public static VehicleStatsEngineImmobilizerWithDecorationState FromCustom(string value)
    {
        return new VehicleStatsEngineImmobilizerWithDecorationState(value);
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
        VehicleStatsEngineImmobilizerWithDecorationState value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        VehicleStatsEngineImmobilizerWithDecorationState value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        VehicleStatsEngineImmobilizerWithDecorationState value
    ) => value.Value;

    public static explicit operator VehicleStatsEngineImmobilizerWithDecorationState(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string IgnitionDisabled = "ignition_disabled";

        public const string IgnitionEnabled = "ignition_enabled";
    }
}
