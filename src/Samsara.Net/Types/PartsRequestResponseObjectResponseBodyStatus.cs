using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<PartsRequestResponseObjectResponseBodyStatus>))]
[Serializable]
public readonly record struct PartsRequestResponseObjectResponseBodyStatus : IStringEnum
{
    public static readonly PartsRequestResponseObjectResponseBodyStatus Draft = new(Values.Draft);

    public static readonly PartsRequestResponseObjectResponseBodyStatus Submitted = new(
        Values.Submitted
    );

    public static readonly PartsRequestResponseObjectResponseBodyStatus PartiallyOrdered = new(
        Values.PartiallyOrdered
    );

    public static readonly PartsRequestResponseObjectResponseBodyStatus Ordered = new(
        Values.Ordered
    );

    public static readonly PartsRequestResponseObjectResponseBodyStatus PartiallyReceived = new(
        Values.PartiallyReceived
    );

    public static readonly PartsRequestResponseObjectResponseBodyStatus Received = new(
        Values.Received
    );

    public static readonly PartsRequestResponseObjectResponseBodyStatus Closed = new(Values.Closed);

    public static readonly PartsRequestResponseObjectResponseBodyStatus Cancelled = new(
        Values.Cancelled
    );

    public static readonly PartsRequestResponseObjectResponseBodyStatus Unknown = new(
        Values.Unknown
    );

    public PartsRequestResponseObjectResponseBodyStatus(string value)
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
    public static PartsRequestResponseObjectResponseBodyStatus FromCustom(string value)
    {
        return new PartsRequestResponseObjectResponseBodyStatus(value);
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
        PartsRequestResponseObjectResponseBodyStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PartsRequestResponseObjectResponseBodyStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PartsRequestResponseObjectResponseBodyStatus value) =>
        value.Value;

    public static explicit operator PartsRequestResponseObjectResponseBodyStatus(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Draft = "draft";

        public const string Submitted = "submitted";

        public const string PartiallyOrdered = "partiallyOrdered";

        public const string Ordered = "ordered";

        public const string PartiallyReceived = "partiallyReceived";

        public const string Received = "received";

        public const string Closed = "closed";

        public const string Cancelled = "cancelled";

        public const string Unknown = "unknown";
    }
}
