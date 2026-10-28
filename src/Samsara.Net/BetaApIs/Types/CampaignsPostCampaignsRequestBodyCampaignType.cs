using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[JsonConverter(typeof(StringEnumSerializer<CampaignsPostCampaignsRequestBodyCampaignType>))]
[Serializable]
public readonly record struct CampaignsPostCampaignsRequestBodyCampaignType : IStringEnum
{
    public static readonly CampaignsPostCampaignsRequestBodyCampaignType SafetyRecall = new(
        Values.SafetyRecall
    );

    public static readonly CampaignsPostCampaignsRequestBodyCampaignType MandatoryCampaign = new(
        Values.MandatoryCampaign
    );

    public static readonly CampaignsPostCampaignsRequestBodyCampaignType Voluntary = new(
        Values.Voluntary
    );

    public static readonly CampaignsPostCampaignsRequestBodyCampaignType Internal = new(
        Values.Internal
    );

    public CampaignsPostCampaignsRequestBodyCampaignType(string value)
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
    public static CampaignsPostCampaignsRequestBodyCampaignType FromCustom(string value)
    {
        return new CampaignsPostCampaignsRequestBodyCampaignType(value);
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
        CampaignsPostCampaignsRequestBodyCampaignType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        CampaignsPostCampaignsRequestBodyCampaignType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(CampaignsPostCampaignsRequestBodyCampaignType value) =>
        value.Value;

    public static explicit operator CampaignsPostCampaignsRequestBodyCampaignType(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string SafetyRecall = "safetyRecall";

        public const string MandatoryCampaign = "mandatoryCampaign";

        public const string Voluntary = "voluntary";

        public const string Internal = "internal";
    }
}
