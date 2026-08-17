using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[JsonConverter(
    typeof(StringEnumSerializer<EntityGroundIntelligenceIssuesServiceUpdateGroundIntelligenceIssueRequestBodyDismissalReason>)
)]
[Serializable]
public readonly record struct EntityGroundIntelligenceIssuesServiceUpdateGroundIntelligenceIssueRequestBodyDismissalReason
    : IStringEnum
{
    public static readonly EntityGroundIntelligenceIssuesServiceUpdateGroundIntelligenceIssueRequestBodyDismissalReason NotMyJurisdiction =
        new(Values.NotMyJurisdiction);

    public static readonly EntityGroundIntelligenceIssuesServiceUpdateGroundIntelligenceIssueRequestBodyDismissalReason KnownIssue =
        new(Values.KnownIssue);

    public static readonly EntityGroundIntelligenceIssuesServiceUpdateGroundIntelligenceIssueRequestBodyDismissalReason Duplicate =
        new(Values.Duplicate);

    public static readonly EntityGroundIntelligenceIssuesServiceUpdateGroundIntelligenceIssueRequestBodyDismissalReason InaccurateDetection =
        new(Values.InaccurateDetection);

    public static readonly EntityGroundIntelligenceIssuesServiceUpdateGroundIntelligenceIssueRequestBodyDismissalReason Other =
        new(Values.Other);

    public EntityGroundIntelligenceIssuesServiceUpdateGroundIntelligenceIssueRequestBodyDismissalReason(
        string value
    )
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
    public static EntityGroundIntelligenceIssuesServiceUpdateGroundIntelligenceIssueRequestBodyDismissalReason FromCustom(
        string value
    )
    {
        return new EntityGroundIntelligenceIssuesServiceUpdateGroundIntelligenceIssueRequestBodyDismissalReason(
            value
        );
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
        EntityGroundIntelligenceIssuesServiceUpdateGroundIntelligenceIssueRequestBodyDismissalReason value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        EntityGroundIntelligenceIssuesServiceUpdateGroundIntelligenceIssueRequestBodyDismissalReason value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        EntityGroundIntelligenceIssuesServiceUpdateGroundIntelligenceIssueRequestBodyDismissalReason value
    ) => value.Value;

    public static explicit operator EntityGroundIntelligenceIssuesServiceUpdateGroundIntelligenceIssueRequestBodyDismissalReason(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string NotMyJurisdiction = "notMyJurisdiction";

        public const string KnownIssue = "knownIssue";

        public const string Duplicate = "duplicate";

        public const string InaccurateDetection = "inaccurateDetection";

        public const string Other = "other";
    }
}
