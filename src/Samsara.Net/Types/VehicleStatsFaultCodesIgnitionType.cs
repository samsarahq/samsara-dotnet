using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<VehicleStatsFaultCodesIgnitionType>))]
[Serializable]
public readonly record struct VehicleStatsFaultCodesIgnitionType : IStringEnum
{
    public static readonly VehicleStatsFaultCodesIgnitionType Spark = new(Values.Spark);

    public static readonly VehicleStatsFaultCodesIgnitionType Compression = new(Values.Compression);

    public VehicleStatsFaultCodesIgnitionType(string value)
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
    public static VehicleStatsFaultCodesIgnitionType FromCustom(string value)
    {
        return new VehicleStatsFaultCodesIgnitionType(value);
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

    public static bool operator ==(VehicleStatsFaultCodesIgnitionType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(VehicleStatsFaultCodesIgnitionType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(VehicleStatsFaultCodesIgnitionType value) => value.Value;

    public static explicit operator VehicleStatsFaultCodesIgnitionType(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Spark = "spark";

        public const string Compression = "compression";
    }
}
