using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[JsonConverter(
    typeof(StringEnumSerializer<EntityWatchpointsServiceCreateWatchpointRequestBodyMode>)
)]
[Serializable]
public readonly record struct EntityWatchpointsServiceCreateWatchpointRequestBodyMode : IStringEnum
{
    public static readonly EntityWatchpointsServiceCreateWatchpointRequestBodyMode JustOnce = new(
        Values.JustOnce
    );

    public static readonly EntityWatchpointsServiceCreateWatchpointRequestBodyMode Daily = new(
        Values.Daily
    );

    public static readonly EntityWatchpointsServiceCreateWatchpointRequestBodyMode Weekly = new(
        Values.Weekly
    );

    public static readonly EntityWatchpointsServiceCreateWatchpointRequestBodyMode Monthly = new(
        Values.Monthly
    );

    public EntityWatchpointsServiceCreateWatchpointRequestBodyMode(string value)
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
    public static EntityWatchpointsServiceCreateWatchpointRequestBodyMode FromCustom(string value)
    {
        return new EntityWatchpointsServiceCreateWatchpointRequestBodyMode(value);
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
        EntityWatchpointsServiceCreateWatchpointRequestBodyMode value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        EntityWatchpointsServiceCreateWatchpointRequestBodyMode value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        EntityWatchpointsServiceCreateWatchpointRequestBodyMode value
    ) => value.Value;

    public static explicit operator EntityWatchpointsServiceCreateWatchpointRequestBodyMode(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string JustOnce = "justOnce";

        public const string Daily = "daily";

        public const string Weekly = "weekly";

        public const string Monthly = "monthly";
    }
}
