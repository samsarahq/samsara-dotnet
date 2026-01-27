using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<HealthResponseResponseBodyHealthStatus>))]
[Serializable]
public readonly record struct HealthResponseResponseBodyHealthStatus : IStringEnum
{
    public static readonly HealthResponseResponseBodyHealthStatus DataPending = new(
        Values.DataPending
    );

    public static readonly HealthResponseResponseBodyHealthStatus Healthy = new(Values.Healthy);

    public static readonly HealthResponseResponseBodyHealthStatus NeedsAttention = new(
        Values.NeedsAttention
    );

    public static readonly HealthResponseResponseBodyHealthStatus NeedsReplacement = new(
        Values.NeedsReplacement
    );

    public HealthResponseResponseBodyHealthStatus(string value)
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
    public static HealthResponseResponseBodyHealthStatus FromCustom(string value)
    {
        return new HealthResponseResponseBodyHealthStatus(value);
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

    public static bool operator ==(HealthResponseResponseBodyHealthStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(HealthResponseResponseBodyHealthStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(HealthResponseResponseBodyHealthStatus value) =>
        value.Value;

    public static explicit operator HealthResponseResponseBodyHealthStatus(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string DataPending = "dataPending";

        public const string Healthy = "healthy";

        public const string NeedsAttention = "needsAttention";

        public const string NeedsReplacement = "needsReplacement";
    }
}
