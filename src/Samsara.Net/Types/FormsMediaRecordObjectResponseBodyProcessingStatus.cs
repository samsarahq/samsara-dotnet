using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<FormsMediaRecordObjectResponseBodyProcessingStatus>))]
[Serializable]
public readonly record struct FormsMediaRecordObjectResponseBodyProcessingStatus : IStringEnum
{
    public static readonly FormsMediaRecordObjectResponseBodyProcessingStatus Unknown = new(
        Values.Unknown
    );

    public static readonly FormsMediaRecordObjectResponseBodyProcessingStatus Processing = new(
        Values.Processing
    );

    public static readonly FormsMediaRecordObjectResponseBodyProcessingStatus Finished = new(
        Values.Finished
    );

    public FormsMediaRecordObjectResponseBodyProcessingStatus(string value)
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
    public static FormsMediaRecordObjectResponseBodyProcessingStatus FromCustom(string value)
    {
        return new FormsMediaRecordObjectResponseBodyProcessingStatus(value);
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
        FormsMediaRecordObjectResponseBodyProcessingStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        FormsMediaRecordObjectResponseBodyProcessingStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        FormsMediaRecordObjectResponseBodyProcessingStatus value
    ) => value.Value;

    public static explicit operator FormsMediaRecordObjectResponseBodyProcessingStatus(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Unknown = "unknown";

        public const string Processing = "processing";

        public const string Finished = "finished";
    }
}
