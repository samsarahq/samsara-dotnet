using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<AgentStudioVoiceSessionTranscriptEntryResponseBodySpeakerType>)
)]
[Serializable]
public readonly record struct AgentStudioVoiceSessionTranscriptEntryResponseBodySpeakerType
    : IStringEnum
{
    public static readonly AgentStudioVoiceSessionTranscriptEntryResponseBodySpeakerType Agent =
        new(Values.Agent);

    public static readonly AgentStudioVoiceSessionTranscriptEntryResponseBodySpeakerType Driver =
        new(Values.Driver);

    public static readonly AgentStudioVoiceSessionTranscriptEntryResponseBodySpeakerType Admin =
        new(Values.Admin);

    public static readonly AgentStudioVoiceSessionTranscriptEntryResponseBodySpeakerType Unknown =
        new(Values.Unknown);

    public AgentStudioVoiceSessionTranscriptEntryResponseBodySpeakerType(string value)
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
    public static AgentStudioVoiceSessionTranscriptEntryResponseBodySpeakerType FromCustom(
        string value
    )
    {
        return new AgentStudioVoiceSessionTranscriptEntryResponseBodySpeakerType(value);
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
        AgentStudioVoiceSessionTranscriptEntryResponseBodySpeakerType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AgentStudioVoiceSessionTranscriptEntryResponseBodySpeakerType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        AgentStudioVoiceSessionTranscriptEntryResponseBodySpeakerType value
    ) => value.Value;

    public static explicit operator AgentStudioVoiceSessionTranscriptEntryResponseBodySpeakerType(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Agent = "agent";

        public const string Driver = "driver";

        public const string Admin = "admin";

        public const string Unknown = "unknown";
    }
}
