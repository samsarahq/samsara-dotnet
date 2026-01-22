using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<VehicleStatsSpreaderActiveValue>))]
[Serializable]
public readonly record struct VehicleStatsSpreaderActiveValue : IStringEnum
{
    public static readonly VehicleStatsSpreaderActiveValue Off = new(Values.Off);

    public static readonly VehicleStatsSpreaderActiveValue On = new(Values.On);

    public VehicleStatsSpreaderActiveValue(string value)
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
    public static VehicleStatsSpreaderActiveValue FromCustom(string value)
    {
        return new VehicleStatsSpreaderActiveValue(value);
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

    public static bool operator ==(VehicleStatsSpreaderActiveValue value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(VehicleStatsSpreaderActiveValue value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(VehicleStatsSpreaderActiveValue value) => value.Value;

    public static explicit operator VehicleStatsSpreaderActiveValue(string value) => new(value);

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
