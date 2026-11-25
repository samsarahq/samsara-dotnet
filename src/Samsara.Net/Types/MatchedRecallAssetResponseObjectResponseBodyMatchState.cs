using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<MatchedRecallAssetResponseObjectResponseBodyMatchState>)
)]
[Serializable]
public readonly record struct MatchedRecallAssetResponseObjectResponseBodyMatchState : IStringEnum
{
    public static readonly MatchedRecallAssetResponseObjectResponseBodyMatchState Matched = new(
        Values.Matched
    );

    public static readonly MatchedRecallAssetResponseObjectResponseBodyMatchState MatchEnded = new(
        Values.MatchEnded
    );

    public static readonly MatchedRecallAssetResponseObjectResponseBodyMatchState Unknown = new(
        Values.Unknown
    );

    public MatchedRecallAssetResponseObjectResponseBodyMatchState(string value)
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
    public static MatchedRecallAssetResponseObjectResponseBodyMatchState FromCustom(string value)
    {
        return new MatchedRecallAssetResponseObjectResponseBodyMatchState(value);
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
        MatchedRecallAssetResponseObjectResponseBodyMatchState value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        MatchedRecallAssetResponseObjectResponseBodyMatchState value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        MatchedRecallAssetResponseObjectResponseBodyMatchState value
    ) => value.Value;

    public static explicit operator MatchedRecallAssetResponseObjectResponseBodyMatchState(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Matched = "matched";

        public const string MatchEnded = "matchEnded";

        public const string Unknown = "unknown";
    }
}
