using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[JsonConverter(
    typeof(StringEnumSerializer<EntityGroundIntelligenceIssuesServiceUpdateGroundIntelligenceIssueRequestBodyStatus>)
)]
[Serializable]
public readonly record struct EntityGroundIntelligenceIssuesServiceUpdateGroundIntelligenceIssueRequestBodyStatus
    : IStringEnum
{
    public static readonly EntityGroundIntelligenceIssuesServiceUpdateGroundIntelligenceIssueRequestBodyStatus NeedsReview =
        new(Values.NeedsReview);

    public static readonly EntityGroundIntelligenceIssuesServiceUpdateGroundIntelligenceIssueRequestBodyStatus Reviewed =
        new(Values.Reviewed);

    public static readonly EntityGroundIntelligenceIssuesServiceUpdateGroundIntelligenceIssueRequestBodyStatus Resolved =
        new(Values.Resolved);

    public static readonly EntityGroundIntelligenceIssuesServiceUpdateGroundIntelligenceIssueRequestBodyStatus Dismissed =
        new(Values.Dismissed);

    public EntityGroundIntelligenceIssuesServiceUpdateGroundIntelligenceIssueRequestBodyStatus(
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
    public static EntityGroundIntelligenceIssuesServiceUpdateGroundIntelligenceIssueRequestBodyStatus FromCustom(
        string value
    )
    {
        return new EntityGroundIntelligenceIssuesServiceUpdateGroundIntelligenceIssueRequestBodyStatus(
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
        EntityGroundIntelligenceIssuesServiceUpdateGroundIntelligenceIssueRequestBodyStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        EntityGroundIntelligenceIssuesServiceUpdateGroundIntelligenceIssueRequestBodyStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        EntityGroundIntelligenceIssuesServiceUpdateGroundIntelligenceIssueRequestBodyStatus value
    ) => value.Value;

    public static explicit operator EntityGroundIntelligenceIssuesServiceUpdateGroundIntelligenceIssueRequestBodyStatus(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string NeedsReview = "needsReview";

        public const string Reviewed = "reviewed";

        public const string Resolved = "resolved";

        public const string Dismissed = "dismissed";
    }
}
