using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<CampaignRecallMetadataRequestObjectRequestBodyRecallSource>)
)]
[Serializable]
public readonly record struct CampaignRecallMetadataRequestObjectRequestBodyRecallSource
    : IStringEnum
{
    public static readonly CampaignRecallMetadataRequestObjectRequestBodyRecallSource RecallMasters =
        new(Values.RecallMasters);

    public static readonly CampaignRecallMetadataRequestObjectRequestBodyRecallSource Nhtsa = new(
        Values.Nhtsa
    );

    public static readonly CampaignRecallMetadataRequestObjectRequestBodyRecallSource Oem = new(
        Values.Oem
    );

    public static readonly CampaignRecallMetadataRequestObjectRequestBodyRecallSource Manual = new(
        Values.Manual
    );

    public static readonly CampaignRecallMetadataRequestObjectRequestBodyRecallSource Api = new(
        Values.Api
    );

    public CampaignRecallMetadataRequestObjectRequestBodyRecallSource(string value)
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
    public static CampaignRecallMetadataRequestObjectRequestBodyRecallSource FromCustom(
        string value
    )
    {
        return new CampaignRecallMetadataRequestObjectRequestBodyRecallSource(value);
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
        CampaignRecallMetadataRequestObjectRequestBodyRecallSource value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        CampaignRecallMetadataRequestObjectRequestBodyRecallSource value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        CampaignRecallMetadataRequestObjectRequestBodyRecallSource value
    ) => value.Value;

    public static explicit operator CampaignRecallMetadataRequestObjectRequestBodyRecallSource(
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
    }
}
