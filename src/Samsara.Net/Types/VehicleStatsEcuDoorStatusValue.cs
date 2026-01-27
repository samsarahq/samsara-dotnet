using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<VehicleStatsEcuDoorStatusValue>))]
[Serializable]
public readonly record struct VehicleStatsEcuDoorStatusValue : IStringEnum
{
    public static readonly VehicleStatsEcuDoorStatusValue Closed = new(Values.Closed);

    public static readonly VehicleStatsEcuDoorStatusValue Open = new(Values.Open);

    public static readonly VehicleStatsEcuDoorStatusValue Unknown = new(Values.Unknown);

    public VehicleStatsEcuDoorStatusValue(string value)
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
    public static VehicleStatsEcuDoorStatusValue FromCustom(string value)
    {
        return new VehicleStatsEcuDoorStatusValue(value);
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

    public static bool operator ==(VehicleStatsEcuDoorStatusValue value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(VehicleStatsEcuDoorStatusValue value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(VehicleStatsEcuDoorStatusValue value) => value.Value;

    public static explicit operator VehicleStatsEcuDoorStatusValue(string value) => new(value);

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
