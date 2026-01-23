using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<UpdateEngineImmobilizerRelayStateRequestBodyRequestBodyId>)
)]
[Serializable]
public readonly record struct UpdateEngineImmobilizerRelayStateRequestBodyRequestBodyId
    : IStringEnum
{
    public static readonly UpdateEngineImmobilizerRelayStateRequestBodyRequestBodyId Relay1 = new(
        Values.Relay1
    );

    public static readonly UpdateEngineImmobilizerRelayStateRequestBodyRequestBodyId Relay2 = new(
        Values.Relay2
    );

    public UpdateEngineImmobilizerRelayStateRequestBodyRequestBodyId(string value)
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
    public static UpdateEngineImmobilizerRelayStateRequestBodyRequestBodyId FromCustom(string value)
    {
        return new UpdateEngineImmobilizerRelayStateRequestBodyRequestBodyId(value);
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
        UpdateEngineImmobilizerRelayStateRequestBodyRequestBodyId value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        UpdateEngineImmobilizerRelayStateRequestBodyRequestBodyId value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        UpdateEngineImmobilizerRelayStateRequestBodyRequestBodyId value
    ) => value.Value;

    public static explicit operator UpdateEngineImmobilizerRelayStateRequestBodyRequestBodyId(
        string value
    ) => new(value);

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
