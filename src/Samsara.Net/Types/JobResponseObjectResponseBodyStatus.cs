using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<JobResponseObjectResponseBodyStatus>))]
[Serializable]
public readonly record struct JobResponseObjectResponseBodyStatus : IStringEnum
{
    public static readonly JobResponseObjectResponseBodyStatus Active = new(Values.Active);

    public static readonly JobResponseObjectResponseBodyStatus Scheduled = new(Values.Scheduled);

    public static readonly JobResponseObjectResponseBodyStatus Completed = new(Values.Completed);

    public JobResponseObjectResponseBodyStatus(string value)
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
    public static JobResponseObjectResponseBodyStatus FromCustom(string value)
    {
        return new JobResponseObjectResponseBodyStatus(value);
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

    public static bool operator ==(JobResponseObjectResponseBodyStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(JobResponseObjectResponseBodyStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(JobResponseObjectResponseBodyStatus value) =>
        value.Value;

    public static explicit operator JobResponseObjectResponseBodyStatus(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Active = "active";

        public const string Scheduled = "scheduled";

        public const string Completed = "completed";
    }
}
