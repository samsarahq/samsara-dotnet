using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<VehicleStatsSpreaderOnStateValue>))]
[Serializable]
public readonly record struct VehicleStatsSpreaderOnStateValue : IStringEnum
{
    public static readonly VehicleStatsSpreaderOnStateValue On = new(Values.On);

    public static readonly VehicleStatsSpreaderOnStateValue Off = new(Values.Off);

    public VehicleStatsSpreaderOnStateValue(string value)
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
    public static VehicleStatsSpreaderOnStateValue FromCustom(string value)
    {
        return new VehicleStatsSpreaderOnStateValue(value);
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

    public static bool operator ==(VehicleStatsSpreaderOnStateValue value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(VehicleStatsSpreaderOnStateValue value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(VehicleStatsSpreaderOnStateValue value) => value.Value;

    public static explicit operator VehicleStatsSpreaderOnStateValue(string value) => new(value);

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
