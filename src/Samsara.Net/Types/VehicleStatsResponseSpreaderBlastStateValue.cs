using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<VehicleStatsResponseSpreaderBlastStateValue>))]
[Serializable]
public readonly record struct VehicleStatsResponseSpreaderBlastStateValue : IStringEnum
{
    public static readonly VehicleStatsResponseSpreaderBlastStateValue On = new(Values.On);

    public static readonly VehicleStatsResponseSpreaderBlastStateValue Off = new(Values.Off);

    public VehicleStatsResponseSpreaderBlastStateValue(string value)
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
    public static VehicleStatsResponseSpreaderBlastStateValue FromCustom(string value)
    {
        return new VehicleStatsResponseSpreaderBlastStateValue(value);
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
        VehicleStatsResponseSpreaderBlastStateValue value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        VehicleStatsResponseSpreaderBlastStateValue value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(VehicleStatsResponseSpreaderBlastStateValue value) =>
        value.Value;

    public static explicit operator VehicleStatsResponseSpreaderBlastStateValue(string value) =>
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
