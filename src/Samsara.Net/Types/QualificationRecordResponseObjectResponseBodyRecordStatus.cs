using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<QualificationRecordResponseObjectResponseBodyRecordStatus>)
)]
[Serializable]
public readonly record struct QualificationRecordResponseObjectResponseBodyRecordStatus
    : IStringEnum
{
    public static readonly QualificationRecordResponseObjectResponseBodyRecordStatus Active = new(
        Values.Active
    );

    public static readonly QualificationRecordResponseObjectResponseBodyRecordStatus Archived = new(
        Values.Archived
    );

    public static readonly QualificationRecordResponseObjectResponseBodyRecordStatus Deleted = new(
        Values.Deleted
    );

    public QualificationRecordResponseObjectResponseBodyRecordStatus(string value)
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
    public static QualificationRecordResponseObjectResponseBodyRecordStatus FromCustom(string value)
    {
        return new QualificationRecordResponseObjectResponseBodyRecordStatus(value);
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
        QualificationRecordResponseObjectResponseBodyRecordStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        QualificationRecordResponseObjectResponseBodyRecordStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        QualificationRecordResponseObjectResponseBodyRecordStatus value
    ) => value.Value;

    public static explicit operator QualificationRecordResponseObjectResponseBodyRecordStatus(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Active = "active";

        public const string Archived = "archived";

        public const string Deleted = "deleted";
    }
}
