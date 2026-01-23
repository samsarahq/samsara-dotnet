using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<VehicleStatsDecorationsEngineStatesValue>))]
[Serializable]
public readonly record struct VehicleStatsDecorationsEngineStatesValue : IStringEnum
{
    public static readonly VehicleStatsDecorationsEngineStatesValue Off = new(Values.Off);

    public static readonly VehicleStatsDecorationsEngineStatesValue On = new(Values.On);

    public static readonly VehicleStatsDecorationsEngineStatesValue Idle = new(Values.Idle);

    public VehicleStatsDecorationsEngineStatesValue(string value)
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
    public static VehicleStatsDecorationsEngineStatesValue FromCustom(string value)
    {
        return new VehicleStatsDecorationsEngineStatesValue(value);
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
        VehicleStatsDecorationsEngineStatesValue value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        VehicleStatsDecorationsEngineStatesValue value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(VehicleStatsDecorationsEngineStatesValue value) =>
        value.Value;

    public static explicit operator VehicleStatsDecorationsEngineStatesValue(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Off = "Off";

        public const string On = "On";

        public const string Idle = "Idle";
    }
}
