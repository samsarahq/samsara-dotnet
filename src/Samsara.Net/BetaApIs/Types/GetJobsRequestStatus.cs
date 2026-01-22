using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[JsonConverter(typeof(StringEnumSerializer<GetJobsRequestStatus>))]
[Serializable]
public readonly record struct GetJobsRequestStatus : IStringEnum
{
    public static readonly GetJobsRequestStatus Active = new(Values.Active);

    public static readonly GetJobsRequestStatus Scheduled = new(Values.Scheduled);

    public static readonly GetJobsRequestStatus Completed = new(Values.Completed);

    public GetJobsRequestStatus(string value)
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
    public static GetJobsRequestStatus FromCustom(string value)
    {
        return new GetJobsRequestStatus(value);
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

    public static bool operator ==(GetJobsRequestStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(GetJobsRequestStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(GetJobsRequestStatus value) => value.Value;

    public static explicit operator GetJobsRequestStatus(string value) => new(value);

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
