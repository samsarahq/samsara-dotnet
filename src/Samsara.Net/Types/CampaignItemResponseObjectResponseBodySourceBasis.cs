using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<CampaignItemResponseObjectResponseBodySourceBasis>))]
[Serializable]
public readonly record struct CampaignItemResponseObjectResponseBodySourceBasis : IStringEnum
{
    public static readonly CampaignItemResponseObjectResponseBodySourceBasis Api = new(Values.Api);

    public static readonly CampaignItemResponseObjectResponseBodySourceBasis Targeting = new(
        Values.Targeting
    );

    public static readonly CampaignItemResponseObjectResponseBodySourceBasis Manual = new(
        Values.Manual
    );

    public static readonly CampaignItemResponseObjectResponseBodySourceBasis Csv = new(Values.Csv);

    public static readonly CampaignItemResponseObjectResponseBodySourceBasis Assistant = new(
        Values.Assistant
    );

    public static readonly CampaignItemResponseObjectResponseBodySourceBasis Unknown = new(
        Values.Unknown
    );

    public CampaignItemResponseObjectResponseBodySourceBasis(string value)
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
    public static CampaignItemResponseObjectResponseBodySourceBasis FromCustom(string value)
    {
        return new CampaignItemResponseObjectResponseBodySourceBasis(value);
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
        CampaignItemResponseObjectResponseBodySourceBasis value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        CampaignItemResponseObjectResponseBodySourceBasis value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        CampaignItemResponseObjectResponseBodySourceBasis value
    ) => value.Value;

    public static explicit operator CampaignItemResponseObjectResponseBodySourceBasis(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Api = "api";

        public const string Targeting = "targeting";

        public const string Manual = "manual";

        public const string Csv = "csv";

        public const string Assistant = "assistant";

        public const string Unknown = "unknown";
    }
}
