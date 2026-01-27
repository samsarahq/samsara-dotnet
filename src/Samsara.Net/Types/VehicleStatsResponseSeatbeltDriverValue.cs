using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<VehicleStatsResponseSeatbeltDriverValue>))]
[Serializable]
public readonly record struct VehicleStatsResponseSeatbeltDriverValue : IStringEnum
{
    public static readonly VehicleStatsResponseSeatbeltDriverValue Buckled = new(Values.Buckled);

    public static readonly VehicleStatsResponseSeatbeltDriverValue Unbuckled = new(
        Values.Unbuckled
    );

    public VehicleStatsResponseSeatbeltDriverValue(string value)
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
    public static VehicleStatsResponseSeatbeltDriverValue FromCustom(string value)
    {
        return new VehicleStatsResponseSeatbeltDriverValue(value);
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

    public static bool operator ==(VehicleStatsResponseSeatbeltDriverValue value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(VehicleStatsResponseSeatbeltDriverValue value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(VehicleStatsResponseSeatbeltDriverValue value) =>
        value.Value;

    public static explicit operator VehicleStatsResponseSeatbeltDriverValue(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Buckled = "Buckled";

        public const string Unbuckled = "Unbuckled";
    }
}
