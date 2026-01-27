using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<EngineImmobilizerRelayStateResponseBodyId>))]
[Serializable]
public readonly record struct EngineImmobilizerRelayStateResponseBodyId : IStringEnum
{
    public static readonly EngineImmobilizerRelayStateResponseBodyId Relay1 = new(Values.Relay1);

    public static readonly EngineImmobilizerRelayStateResponseBodyId Relay2 = new(Values.Relay2);

    public EngineImmobilizerRelayStateResponseBodyId(string value)
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
    public static EngineImmobilizerRelayStateResponseBodyId FromCustom(string value)
    {
        return new EngineImmobilizerRelayStateResponseBodyId(value);
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
        EngineImmobilizerRelayStateResponseBodyId value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        EngineImmobilizerRelayStateResponseBodyId value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(EngineImmobilizerRelayStateResponseBodyId value) =>
        value.Value;

    public static explicit operator EngineImmobilizerRelayStateResponseBodyId(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Relay1 = "relay1";

        public const string Relay2 = "relay2";
    }
}
