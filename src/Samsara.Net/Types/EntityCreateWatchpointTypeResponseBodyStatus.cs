using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<EntityCreateWatchpointTypeResponseBodyStatus>))]
[Serializable]
public readonly record struct EntityCreateWatchpointTypeResponseBodyStatus : IStringEnum
{
    public static readonly EntityCreateWatchpointTypeResponseBodyStatus Unknown = new(
        Values.Unknown
    );

    public static readonly EntityCreateWatchpointTypeResponseBodyStatus Active = new(Values.Active);

    public static readonly EntityCreateWatchpointTypeResponseBodyStatus Completed = new(
        Values.Completed
    );

    public EntityCreateWatchpointTypeResponseBodyStatus(string value)
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
    public static EntityCreateWatchpointTypeResponseBodyStatus FromCustom(string value)
    {
        return new EntityCreateWatchpointTypeResponseBodyStatus(value);
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
        EntityCreateWatchpointTypeResponseBodyStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        EntityCreateWatchpointTypeResponseBodyStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(EntityCreateWatchpointTypeResponseBodyStatus value) =>
        value.Value;

    public static explicit operator EntityCreateWatchpointTypeResponseBodyStatus(string value) =>
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
