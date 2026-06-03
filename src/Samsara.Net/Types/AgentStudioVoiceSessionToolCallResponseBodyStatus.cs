using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<AgentStudioVoiceSessionToolCallResponseBodyStatus>))]
[Serializable]
public readonly record struct AgentStudioVoiceSessionToolCallResponseBodyStatus : IStringEnum
{
    public static readonly AgentStudioVoiceSessionToolCallResponseBodyStatus Success = new(
        Values.Success
    );

    public static readonly AgentStudioVoiceSessionToolCallResponseBodyStatus Error = new(
        Values.Error
    );

    public static readonly AgentStudioVoiceSessionToolCallResponseBodyStatus Unknown = new(
        Values.Unknown
    );

    public AgentStudioVoiceSessionToolCallResponseBodyStatus(string value)
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
    public static AgentStudioVoiceSessionToolCallResponseBodyStatus FromCustom(string value)
    {
        return new AgentStudioVoiceSessionToolCallResponseBodyStatus(value);
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
        AgentStudioVoiceSessionToolCallResponseBodyStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AgentStudioVoiceSessionToolCallResponseBodyStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        AgentStudioVoiceSessionToolCallResponseBodyStatus value
    ) => value.Value;

    public static explicit operator AgentStudioVoiceSessionToolCallResponseBodyStatus(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Success = "success";

        public const string Error = "error";

        public const string Unknown = "unknown";
    }
}
