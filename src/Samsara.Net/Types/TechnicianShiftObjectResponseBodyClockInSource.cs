using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<TechnicianShiftObjectResponseBodyClockInSource>))]
[Serializable]
public readonly record struct TechnicianShiftObjectResponseBodyClockInSource : IStringEnum
{
    public static readonly TechnicianShiftObjectResponseBodyClockInSource Api = new(Values.Api);

    public static readonly TechnicianShiftObjectResponseBodyClockInSource Cloud = new(Values.Cloud);

    public static readonly TechnicianShiftObjectResponseBodyClockInSource Mobile = new(
        Values.Mobile
    );

    public static readonly TechnicianShiftObjectResponseBodyClockInSource Unknown = new(
        Values.Unknown
    );

    public TechnicianShiftObjectResponseBodyClockInSource(string value)
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
    public static TechnicianShiftObjectResponseBodyClockInSource FromCustom(string value)
    {
        return new TechnicianShiftObjectResponseBodyClockInSource(value);
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
        TechnicianShiftObjectResponseBodyClockInSource value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        TechnicianShiftObjectResponseBodyClockInSource value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(TechnicianShiftObjectResponseBodyClockInSource value) =>
        value.Value;

    public static explicit operator TechnicianShiftObjectResponseBodyClockInSource(string value) =>
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
