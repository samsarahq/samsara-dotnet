using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<TrainingCourseResponseObjectResponseBodyStatus>))]
[Serializable]
public readonly record struct TrainingCourseResponseObjectResponseBodyStatus : IStringEnum
{
    public static readonly TrainingCourseResponseObjectResponseBodyStatus Published = new(
        Values.Published
    );

    public static readonly TrainingCourseResponseObjectResponseBodyStatus Deleted = new(
        Values.Deleted
    );

    public static readonly TrainingCourseResponseObjectResponseBodyStatus Archived = new(
        Values.Archived
    );

    public static readonly TrainingCourseResponseObjectResponseBodyStatus Unknown = new(
        Values.Unknown
    );

    public TrainingCourseResponseObjectResponseBodyStatus(string value)
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
    public static TrainingCourseResponseObjectResponseBodyStatus FromCustom(string value)
    {
        return new TrainingCourseResponseObjectResponseBodyStatus(value);
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
        TrainingCourseResponseObjectResponseBodyStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        TrainingCourseResponseObjectResponseBodyStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(TrainingCourseResponseObjectResponseBodyStatus value) =>
        value.Value;

    public static explicit operator TrainingCourseResponseObjectResponseBodyStatus(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Published = "published";

        public const string Deleted = "deleted";

        public const string Archived = "archived";

        public const string Unknown = "unknown";
    }
}
