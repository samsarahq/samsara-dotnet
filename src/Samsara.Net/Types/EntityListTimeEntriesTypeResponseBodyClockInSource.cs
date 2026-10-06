using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<EntityListTimeEntriesTypeResponseBodyClockInSource>))]
[Serializable]
public readonly record struct EntityListTimeEntriesTypeResponseBodyClockInSource : IStringEnum
{
    public static readonly EntityListTimeEntriesTypeResponseBodyClockInSource Unknown = new(
        Values.Unknown
    );

    public static readonly EntityListTimeEntriesTypeResponseBodyClockInSource Cloud = new(
        Values.Cloud
    );

    public static readonly EntityListTimeEntriesTypeResponseBodyClockInSource Mobile = new(
        Values.Mobile
    );

    public EntityListTimeEntriesTypeResponseBodyClockInSource(string value)
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
    public static EntityListTimeEntriesTypeResponseBodyClockInSource FromCustom(string value)
    {
        return new EntityListTimeEntriesTypeResponseBodyClockInSource(value);
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
        EntityListTimeEntriesTypeResponseBodyClockInSource value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        EntityListTimeEntriesTypeResponseBodyClockInSource value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        EntityListTimeEntriesTypeResponseBodyClockInSource value
    ) => value.Value;

    public static explicit operator EntityListTimeEntriesTypeResponseBodyClockInSource(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Unknown = "unknown";

        public const string Cloud = "cloud";

        public const string Mobile = "mobile";
    }
}
