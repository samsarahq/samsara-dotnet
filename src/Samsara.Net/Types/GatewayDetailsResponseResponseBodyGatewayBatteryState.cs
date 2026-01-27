using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<GatewayDetailsResponseResponseBodyGatewayBatteryState>))]
[Serializable]
public readonly record struct GatewayDetailsResponseResponseBodyGatewayBatteryState : IStringEnum
{
    public static readonly GatewayDetailsResponseResponseBodyGatewayBatteryState Critical = new(
        Values.Critical
    );

    public static readonly GatewayDetailsResponseResponseBodyGatewayBatteryState Low = new(
        Values.Low
    );

    public static readonly GatewayDetailsResponseResponseBodyGatewayBatteryState Ok = new(
        Values.Ok
    );

    public static readonly GatewayDetailsResponseResponseBodyGatewayBatteryState Unknown = new(
        Values.Unknown
    );

    public GatewayDetailsResponseResponseBodyGatewayBatteryState(string value)
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
    public static GatewayDetailsResponseResponseBodyGatewayBatteryState FromCustom(string value)
    {
        return new GatewayDetailsResponseResponseBodyGatewayBatteryState(value);
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
        GatewayDetailsResponseResponseBodyGatewayBatteryState value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        GatewayDetailsResponseResponseBodyGatewayBatteryState value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        GatewayDetailsResponseResponseBodyGatewayBatteryState value
    ) => value.Value;

    public static explicit operator GatewayDetailsResponseResponseBodyGatewayBatteryState(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Critical = "critical";

        public const string Low = "low";

        public const string Ok = "ok";

        public const string Unknown = "unknown";
    }
}
