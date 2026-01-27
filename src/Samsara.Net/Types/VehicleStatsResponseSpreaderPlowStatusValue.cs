using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<VehicleStatsResponseSpreaderPlowStatusValue>))]
[Serializable]
public readonly record struct VehicleStatsResponseSpreaderPlowStatusValue : IStringEnum
{
    public static readonly VehicleStatsResponseSpreaderPlowStatusValue Up = new(Values.Up);

    public static readonly VehicleStatsResponseSpreaderPlowStatusValue Down = new(Values.Down);

    public VehicleStatsResponseSpreaderPlowStatusValue(string value)
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
    public static VehicleStatsResponseSpreaderPlowStatusValue FromCustom(string value)
    {
        return new VehicleStatsResponseSpreaderPlowStatusValue(value);
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
        VehicleStatsResponseSpreaderPlowStatusValue value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        VehicleStatsResponseSpreaderPlowStatusValue value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(VehicleStatsResponseSpreaderPlowStatusValue value) =>
        value.Value;

    public static explicit operator VehicleStatsResponseSpreaderPlowStatusValue(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Up = "Up";

        public const string Down = "Down";
    }
}
