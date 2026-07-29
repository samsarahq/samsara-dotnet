using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<EntityUpdateWatchpointTypeResponseBodyMode>))]
[Serializable]
public readonly record struct EntityUpdateWatchpointTypeResponseBodyMode : IStringEnum
{
    public static readonly EntityUpdateWatchpointTypeResponseBodyMode Unknown = new(Values.Unknown);

    public static readonly EntityUpdateWatchpointTypeResponseBodyMode JustOnce = new(
        Values.JustOnce
    );

    public static readonly EntityUpdateWatchpointTypeResponseBodyMode Daily = new(Values.Daily);

    public static readonly EntityUpdateWatchpointTypeResponseBodyMode Weekly = new(Values.Weekly);

    public static readonly EntityUpdateWatchpointTypeResponseBodyMode Monthly = new(Values.Monthly);

    public EntityUpdateWatchpointTypeResponseBodyMode(string value)
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
    public static EntityUpdateWatchpointTypeResponseBodyMode FromCustom(string value)
    {
        return new EntityUpdateWatchpointTypeResponseBodyMode(value);
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
        EntityUpdateWatchpointTypeResponseBodyMode value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        EntityUpdateWatchpointTypeResponseBodyMode value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(EntityUpdateWatchpointTypeResponseBodyMode value) =>
        value.Value;

    public static explicit operator EntityUpdateWatchpointTypeResponseBodyMode(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Unknown = "unknown";

        public const string JustOnce = "justOnce";

        public const string Daily = "daily";

        public const string Weekly = "weekly";

        public const string Monthly = "monthly";
    }
}
