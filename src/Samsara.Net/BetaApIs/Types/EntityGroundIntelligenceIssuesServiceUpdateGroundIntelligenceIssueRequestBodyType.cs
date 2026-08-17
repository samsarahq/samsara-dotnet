using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[JsonConverter(
    typeof(StringEnumSerializer<EntityGroundIntelligenceIssuesServiceUpdateGroundIntelligenceIssueRequestBodyType>)
)]
[Serializable]
public readonly record struct EntityGroundIntelligenceIssuesServiceUpdateGroundIntelligenceIssueRequestBodyType
    : IStringEnum
{
    public static readonly EntityGroundIntelligenceIssuesServiceUpdateGroundIntelligenceIssueRequestBodyType Pothole =
        new(Values.Pothole);

    public static readonly EntityGroundIntelligenceIssuesServiceUpdateGroundIntelligenceIssueRequestBodyType RoadCracking =
        new(Values.RoadCracking);

    public static readonly EntityGroundIntelligenceIssuesServiceUpdateGroundIntelligenceIssueRequestBodyType PatchedPothole =
        new(Values.PatchedPothole);

    public EntityGroundIntelligenceIssuesServiceUpdateGroundIntelligenceIssueRequestBodyType(
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
    public static EntityGroundIntelligenceIssuesServiceUpdateGroundIntelligenceIssueRequestBodyType FromCustom(
        string value
    )
    {
        return new EntityGroundIntelligenceIssuesServiceUpdateGroundIntelligenceIssueRequestBodyType(
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
        EntityGroundIntelligenceIssuesServiceUpdateGroundIntelligenceIssueRequestBodyType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        EntityGroundIntelligenceIssuesServiceUpdateGroundIntelligenceIssueRequestBodyType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        EntityGroundIntelligenceIssuesServiceUpdateGroundIntelligenceIssueRequestBodyType value
    ) => value.Value;

    public static explicit operator EntityGroundIntelligenceIssuesServiceUpdateGroundIntelligenceIssueRequestBodyType(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Pothole = "pothole";

        public const string RoadCracking = "roadCracking";

        public const string PatchedPothole = "patchedPothole";
    }
}
