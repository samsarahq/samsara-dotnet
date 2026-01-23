using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<VehicleStatsResponseSpreaderOnStateValue>))]
[Serializable]
public readonly record struct VehicleStatsResponseSpreaderOnStateValue : IStringEnum
{
    public static readonly VehicleStatsResponseSpreaderOnStateValue On = new(Values.On);

    public static readonly VehicleStatsResponseSpreaderOnStateValue Off = new(Values.Off);

    public VehicleStatsResponseSpreaderOnStateValue(string value)
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
    public static VehicleStatsResponseSpreaderOnStateValue FromCustom(string value)
    {
        return new VehicleStatsResponseSpreaderOnStateValue(value);
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
        VehicleStatsResponseSpreaderOnStateValue value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        VehicleStatsResponseSpreaderOnStateValue value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(VehicleStatsResponseSpreaderOnStateValue value) =>
        value.Value;

    public static explicit operator VehicleStatsResponseSpreaderOnStateValue(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string On = "On";

        public const string Off = "Off";
    }
}
