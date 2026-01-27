using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<VehicleStatsEngineStateSetting>))]
[Serializable]
public readonly record struct VehicleStatsEngineStateSetting : IStringEnum
{
    public static readonly VehicleStatsEngineStateSetting Off = new(Values.Off);

    public static readonly VehicleStatsEngineStateSetting On = new(Values.On);

    public static readonly VehicleStatsEngineStateSetting Idle = new(Values.Idle);

    public VehicleStatsEngineStateSetting(string value)
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
    public static VehicleStatsEngineStateSetting FromCustom(string value)
    {
        return new VehicleStatsEngineStateSetting(value);
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

    public static bool operator ==(VehicleStatsEngineStateSetting value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(VehicleStatsEngineStateSetting value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(VehicleStatsEngineStateSetting value) => value.Value;

    public static explicit operator VehicleStatsEngineStateSetting(string value) => new(value);

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
