using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<CampaignRecallMetadataResponseObjectResponseBodyRecallSource>)
)]
[Serializable]
public readonly record struct CampaignRecallMetadataResponseObjectResponseBodyRecallSource
    : IStringEnum
{
    public static readonly CampaignRecallMetadataResponseObjectResponseBodyRecallSource RecallMasters =
        new(Values.RecallMasters);

    public static readonly CampaignRecallMetadataResponseObjectResponseBodyRecallSource Nhtsa = new(
        Values.Nhtsa
    );

    public static readonly CampaignRecallMetadataResponseObjectResponseBodyRecallSource Oem = new(
        Values.Oem
    );

    public static readonly CampaignRecallMetadataResponseObjectResponseBodyRecallSource Manual =
        new(Values.Manual);

    public static readonly CampaignRecallMetadataResponseObjectResponseBodyRecallSource Api = new(
        Values.Api
    );

    public static readonly CampaignRecallMetadataResponseObjectResponseBodyRecallSource Unknown =
        new(Values.Unknown);

    public CampaignRecallMetadataResponseObjectResponseBodyRecallSource(string value)
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
    public static CampaignRecallMetadataResponseObjectResponseBodyRecallSource FromCustom(
        string value
    )
    {
        return new CampaignRecallMetadataResponseObjectResponseBodyRecallSource(value);
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
        CampaignRecallMetadataResponseObjectResponseBodyRecallSource value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        CampaignRecallMetadataResponseObjectResponseBodyRecallSource value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        CampaignRecallMetadataResponseObjectResponseBodyRecallSource value
    ) => value.Value;

    public static explicit operator CampaignRecallMetadataResponseObjectResponseBodyRecallSource(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string RecallMasters = "recallMasters";

        public const string Nhtsa = "nhtsa";

        public const string Oem = "oem";

        public const string Manual = "manual";

        public const string Api = "api";

        public const string Unknown = "unknown";
    }
}
