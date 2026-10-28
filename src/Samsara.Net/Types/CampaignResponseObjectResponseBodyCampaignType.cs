using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<CampaignResponseObjectResponseBodyCampaignType>))]
[Serializable]
public readonly record struct CampaignResponseObjectResponseBodyCampaignType : IStringEnum
{
    public static readonly CampaignResponseObjectResponseBodyCampaignType SafetyRecall = new(
        Values.SafetyRecall
    );

    public static readonly CampaignResponseObjectResponseBodyCampaignType MandatoryCampaign = new(
        Values.MandatoryCampaign
    );

    public static readonly CampaignResponseObjectResponseBodyCampaignType Voluntary = new(
        Values.Voluntary
    );

    public static readonly CampaignResponseObjectResponseBodyCampaignType Internal = new(
        Values.Internal
    );

    public static readonly CampaignResponseObjectResponseBodyCampaignType Unknown = new(
        Values.Unknown
    );

    public CampaignResponseObjectResponseBodyCampaignType(string value)
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
    public static CampaignResponseObjectResponseBodyCampaignType FromCustom(string value)
    {
        return new CampaignResponseObjectResponseBodyCampaignType(value);
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
        CampaignResponseObjectResponseBodyCampaignType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        CampaignResponseObjectResponseBodyCampaignType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(CampaignResponseObjectResponseBodyCampaignType value) =>
        value.Value;

    public static explicit operator CampaignResponseObjectResponseBodyCampaignType(string value) =>
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

        public const string Unknown = "unknown";
    }
}
