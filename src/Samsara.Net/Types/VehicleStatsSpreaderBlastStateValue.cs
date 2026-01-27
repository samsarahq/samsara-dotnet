using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<VehicleStatsSpreaderBlastStateValue>))]
[Serializable]
public readonly record struct VehicleStatsSpreaderBlastStateValue : IStringEnum
{
    public static readonly VehicleStatsSpreaderBlastStateValue On = new(Values.On);

    public static readonly VehicleStatsSpreaderBlastStateValue Off = new(Values.Off);

    public VehicleStatsSpreaderBlastStateValue(string value)
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
    public static VehicleStatsSpreaderBlastStateValue FromCustom(string value)
    {
        return new VehicleStatsSpreaderBlastStateValue(value);
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

    public static bool operator ==(VehicleStatsSpreaderBlastStateValue value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(VehicleStatsSpreaderBlastStateValue value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(VehicleStatsSpreaderBlastStateValue value) =>
        value.Value;

    public static explicit operator VehicleStatsSpreaderBlastStateValue(string value) => new(value);

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
