using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<ReportRunObjectResponseBodyStatus>))]
[Serializable]
public readonly record struct ReportRunObjectResponseBodyStatus : IStringEnum
{
    public static readonly ReportRunObjectResponseBodyStatus Complete = new(Values.Complete);

    public static readonly ReportRunObjectResponseBodyStatus Pending = new(Values.Pending);

    public static readonly ReportRunObjectResponseBodyStatus Failed = new(Values.Failed);

    public static readonly ReportRunObjectResponseBodyStatus Canceled = new(Values.Canceled);

    public static readonly ReportRunObjectResponseBodyStatus Unknown = new(Values.Unknown);

    public ReportRunObjectResponseBodyStatus(string value)
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
    public static ReportRunObjectResponseBodyStatus FromCustom(string value)
    {
        return new ReportRunObjectResponseBodyStatus(value);
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

    public static bool operator ==(ReportRunObjectResponseBodyStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ReportRunObjectResponseBodyStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ReportRunObjectResponseBodyStatus value) => value.Value;

    public static explicit operator ReportRunObjectResponseBodyStatus(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Complete = "complete";

        public const string Pending = "pending";

        public const string Failed = "failed";

        public const string Canceled = "canceled";

        public const string Unknown = "unknown";
    }
}
