using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<VehicleStatsSeatbeltDriverValue>))]
[Serializable]
public readonly record struct VehicleStatsSeatbeltDriverValue : IStringEnum
{
    public static readonly VehicleStatsSeatbeltDriverValue Buckled = new(Values.Buckled);

    public static readonly VehicleStatsSeatbeltDriverValue Unbuckled = new(Values.Unbuckled);

    public VehicleStatsSeatbeltDriverValue(string value)
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
    public static VehicleStatsSeatbeltDriverValue FromCustom(string value)
    {
        return new VehicleStatsSeatbeltDriverValue(value);
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

    public static bool operator ==(VehicleStatsSeatbeltDriverValue value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(VehicleStatsSeatbeltDriverValue value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(VehicleStatsSeatbeltDriverValue value) => value.Value;

    public static explicit operator VehicleStatsSeatbeltDriverValue(string value) => new(value);

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
