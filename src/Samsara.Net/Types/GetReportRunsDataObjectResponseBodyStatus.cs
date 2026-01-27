using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<GetReportRunsDataObjectResponseBodyStatus>))]
[Serializable]
public readonly record struct GetReportRunsDataObjectResponseBodyStatus : IStringEnum
{
    public static readonly GetReportRunsDataObjectResponseBodyStatus Complete = new(
        Values.Complete
    );

    public static readonly GetReportRunsDataObjectResponseBodyStatus Pending = new(Values.Pending);

    public static readonly GetReportRunsDataObjectResponseBodyStatus Failed = new(Values.Failed);

    public static readonly GetReportRunsDataObjectResponseBodyStatus Canceled = new(
        Values.Canceled
    );

    public static readonly GetReportRunsDataObjectResponseBodyStatus Unknown = new(Values.Unknown);

    public GetReportRunsDataObjectResponseBodyStatus(string value)
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
    public static GetReportRunsDataObjectResponseBodyStatus FromCustom(string value)
    {
        return new GetReportRunsDataObjectResponseBodyStatus(value);
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
        GetReportRunsDataObjectResponseBodyStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        GetReportRunsDataObjectResponseBodyStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(GetReportRunsDataObjectResponseBodyStatus value) =>
        value.Value;

    public static explicit operator GetReportRunsDataObjectResponseBodyStatus(string value) =>
        new(value);

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
