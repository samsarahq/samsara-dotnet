using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<EntityListTimeEntriesTypeResponseBodyTimeEntryStatus>))]
[Serializable]
public readonly record struct EntityListTimeEntriesTypeResponseBodyTimeEntryStatus : IStringEnum
{
    public static readonly EntityListTimeEntriesTypeResponseBodyTimeEntryStatus Unknown = new(
        Values.Unknown
    );

    public static readonly EntityListTimeEntriesTypeResponseBodyTimeEntryStatus InProgress = new(
        Values.InProgress
    );

    public static readonly EntityListTimeEntriesTypeResponseBodyTimeEntryStatus Completed = new(
        Values.Completed
    );

    public EntityListTimeEntriesTypeResponseBodyTimeEntryStatus(string value)
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
    public static EntityListTimeEntriesTypeResponseBodyTimeEntryStatus FromCustom(string value)
    {
        return new EntityListTimeEntriesTypeResponseBodyTimeEntryStatus(value);
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
        EntityListTimeEntriesTypeResponseBodyTimeEntryStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        EntityListTimeEntriesTypeResponseBodyTimeEntryStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        EntityListTimeEntriesTypeResponseBodyTimeEntryStatus value
    ) => value.Value;

    public static explicit operator EntityListTimeEntriesTypeResponseBodyTimeEntryStatus(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Unknown = "unknown";

        public const string InProgress = "inProgress";

        public const string Completed = "completed";
    }
}
