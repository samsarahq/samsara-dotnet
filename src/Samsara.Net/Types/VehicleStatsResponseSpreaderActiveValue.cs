using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<VehicleStatsResponseSpreaderActiveValue>))]
[Serializable]
public readonly record struct VehicleStatsResponseSpreaderActiveValue : IStringEnum
{
    public static readonly VehicleStatsResponseSpreaderActiveValue Off = new(Values.Off);

    public static readonly VehicleStatsResponseSpreaderActiveValue On = new(Values.On);

    public VehicleStatsResponseSpreaderActiveValue(string value)
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
    public static VehicleStatsResponseSpreaderActiveValue FromCustom(string value)
    {
        return new VehicleStatsResponseSpreaderActiveValue(value);
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

    public static bool operator ==(VehicleStatsResponseSpreaderActiveValue value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(VehicleStatsResponseSpreaderActiveValue value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(VehicleStatsResponseSpreaderActiveValue value) =>
        value.Value;

    public static explicit operator VehicleStatsResponseSpreaderActiveValue(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Off = "Off";

        public const string On = "On";
    }
}
