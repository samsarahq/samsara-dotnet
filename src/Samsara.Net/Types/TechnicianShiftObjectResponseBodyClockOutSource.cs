using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<TechnicianShiftObjectResponseBodyClockOutSource>))]
[Serializable]
public readonly record struct TechnicianShiftObjectResponseBodyClockOutSource : IStringEnum
{
    public static readonly TechnicianShiftObjectResponseBodyClockOutSource Api = new(Values.Api);

    public static readonly TechnicianShiftObjectResponseBodyClockOutSource Cloud = new(
        Values.Cloud
    );

    public static readonly TechnicianShiftObjectResponseBodyClockOutSource Mobile = new(
        Values.Mobile
    );

    public static readonly TechnicianShiftObjectResponseBodyClockOutSource Unknown = new(
        Values.Unknown
    );

    public TechnicianShiftObjectResponseBodyClockOutSource(string value)
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
    public static TechnicianShiftObjectResponseBodyClockOutSource FromCustom(string value)
    {
        return new TechnicianShiftObjectResponseBodyClockOutSource(value);
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

    public static bool operator ==(
        TechnicianShiftObjectResponseBodyClockOutSource value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        TechnicianShiftObjectResponseBodyClockOutSource value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(TechnicianShiftObjectResponseBodyClockOutSource value) =>
        value.Value;

    public static explicit operator TechnicianShiftObjectResponseBodyClockOutSource(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Api = "api";

        public const string Cloud = "cloud";

        public const string Mobile = "mobile";

        public const string Unknown = "unknown";
    }
}
