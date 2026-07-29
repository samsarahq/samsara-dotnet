using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<EntityUpdateWatchpointTypeResponseBodyStatus>))]
[Serializable]
public readonly record struct EntityUpdateWatchpointTypeResponseBodyStatus : IStringEnum
{
    public static readonly EntityUpdateWatchpointTypeResponseBodyStatus Unknown = new(
        Values.Unknown
    );

    public static readonly EntityUpdateWatchpointTypeResponseBodyStatus Active = new(Values.Active);

    public static readonly EntityUpdateWatchpointTypeResponseBodyStatus Completed = new(
        Values.Completed
    );

    public EntityUpdateWatchpointTypeResponseBodyStatus(string value)
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
    public static EntityUpdateWatchpointTypeResponseBodyStatus FromCustom(string value)
    {
        return new EntityUpdateWatchpointTypeResponseBodyStatus(value);
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
        EntityUpdateWatchpointTypeResponseBodyStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        EntityUpdateWatchpointTypeResponseBodyStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(EntityUpdateWatchpointTypeResponseBodyStatus value) =>
        value.Value;

    public static explicit operator EntityUpdateWatchpointTypeResponseBodyStatus(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Unknown = "unknown";

        public const string Active = "active";

        public const string Completed = "completed";
    }
}
