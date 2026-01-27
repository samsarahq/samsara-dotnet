using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<VehicleRegulationMode>))]
[Serializable]
public readonly record struct VehicleRegulationMode : IStringEnum
{
    public static readonly VehicleRegulationMode Regulated = new(Values.Regulated);

    public static readonly VehicleRegulationMode Unregulated = new(Values.Unregulated);

    public static readonly VehicleRegulationMode Mixed = new(Values.Mixed);

    public VehicleRegulationMode(string value)
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
    public static VehicleRegulationMode FromCustom(string value)
    {
        return new VehicleRegulationMode(value);
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

    public static bool operator ==(VehicleRegulationMode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(VehicleRegulationMode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(VehicleRegulationMode value) => value.Value;

    public static explicit operator VehicleRegulationMode(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Regulated = "regulated";

        public const string Unregulated = "unregulated";

        public const string Mixed = "mixed";
    }
}
