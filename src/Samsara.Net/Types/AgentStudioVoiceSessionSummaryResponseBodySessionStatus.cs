using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<AgentStudioVoiceSessionSummaryResponseBodySessionStatus>)
)]
[Serializable]
public readonly record struct AgentStudioVoiceSessionSummaryResponseBodySessionStatus : IStringEnum
{
    public static readonly AgentStudioVoiceSessionSummaryResponseBodySessionStatus Completed = new(
        Values.Completed
    );

    public static readonly AgentStudioVoiceSessionSummaryResponseBodySessionStatus Running = new(
        Values.Running
    );

    public static readonly AgentStudioVoiceSessionSummaryResponseBodySessionStatus Failed = new(
        Values.Failed
    );

    public static readonly AgentStudioVoiceSessionSummaryResponseBodySessionStatus Unknown = new(
        Values.Unknown
    );

    public AgentStudioVoiceSessionSummaryResponseBodySessionStatus(string value)
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
    public static AgentStudioVoiceSessionSummaryResponseBodySessionStatus FromCustom(string value)
    {
        return new AgentStudioVoiceSessionSummaryResponseBodySessionStatus(value);
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
        AgentStudioVoiceSessionSummaryResponseBodySessionStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AgentStudioVoiceSessionSummaryResponseBodySessionStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        AgentStudioVoiceSessionSummaryResponseBodySessionStatus value
    ) => value.Value;

    public static explicit operator AgentStudioVoiceSessionSummaryResponseBodySessionStatus(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Completed = "completed";

        public const string Running = "running";

        public const string Failed = "failed";

        public const string Unknown = "unknown";
    }
}
