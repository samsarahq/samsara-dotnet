using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<VehicleStatsSpreaderPlowStatusValue>))]
[Serializable]
public readonly record struct VehicleStatsSpreaderPlowStatusValue : IStringEnum
{
    public static readonly VehicleStatsSpreaderPlowStatusValue Up = new(Values.Up);

    public static readonly VehicleStatsSpreaderPlowStatusValue Down = new(Values.Down);

    public VehicleStatsSpreaderPlowStatusValue(string value)
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
    public static VehicleStatsSpreaderPlowStatusValue FromCustom(string value)
    {
        return new VehicleStatsSpreaderPlowStatusValue(value);
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

    public static bool operator ==(VehicleStatsSpreaderPlowStatusValue value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(VehicleStatsSpreaderPlowStatusValue value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(VehicleStatsSpreaderPlowStatusValue value) =>
        value.Value;

    public static explicit operator VehicleStatsSpreaderPlowStatusValue(string value) => new(value);

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
