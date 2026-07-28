using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<EntityCreateWatchpointTypeResponseBodyMode>))]
[Serializable]
public readonly record struct EntityCreateWatchpointTypeResponseBodyMode : IStringEnum
{
    public static readonly EntityCreateWatchpointTypeResponseBodyMode Unknown = new(Values.Unknown);

    public static readonly EntityCreateWatchpointTypeResponseBodyMode JustOnce = new(
        Values.JustOnce
    );

    public static readonly EntityCreateWatchpointTypeResponseBodyMode Daily = new(Values.Daily);

    public static readonly EntityCreateWatchpointTypeResponseBodyMode Weekly = new(Values.Weekly);

    public static readonly EntityCreateWatchpointTypeResponseBodyMode Monthly = new(Values.Monthly);

    public EntityCreateWatchpointTypeResponseBodyMode(string value)
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
    public static EntityCreateWatchpointTypeResponseBodyMode FromCustom(string value)
    {
        return new EntityCreateWatchpointTypeResponseBodyMode(value);
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
        EntityCreateWatchpointTypeResponseBodyMode value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        EntityCreateWatchpointTypeResponseBodyMode value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(EntityCreateWatchpointTypeResponseBodyMode value) =>
        value.Value;

    public static explicit operator EntityCreateWatchpointTypeResponseBodyMode(string value) =>
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
