using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<VehicleStatsResponseEcuDoorStatusValue>))]
[Serializable]
public readonly record struct VehicleStatsResponseEcuDoorStatusValue : IStringEnum
{
    public static readonly VehicleStatsResponseEcuDoorStatusValue Closed = new(Values.Closed);

    public static readonly VehicleStatsResponseEcuDoorStatusValue Open = new(Values.Open);

    public static readonly VehicleStatsResponseEcuDoorStatusValue Unknown = new(Values.Unknown);

    public VehicleStatsResponseEcuDoorStatusValue(string value)
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
    public static VehicleStatsResponseEcuDoorStatusValue FromCustom(string value)
    {
        return new VehicleStatsResponseEcuDoorStatusValue(value);
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

    public static bool operator ==(VehicleStatsResponseEcuDoorStatusValue value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(VehicleStatsResponseEcuDoorStatusValue value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(VehicleStatsResponseEcuDoorStatusValue value) =>
        value.Value;

    public static explicit operator VehicleStatsResponseEcuDoorStatusValue(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Closed = "Closed";

        public const string Open = "Open";

        public const string Unknown = "Unknown";
    }
}
