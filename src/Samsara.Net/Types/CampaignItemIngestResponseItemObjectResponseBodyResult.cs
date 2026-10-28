using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<CampaignItemIngestResponseItemObjectResponseBodyResult>)
)]
[Serializable]
public readonly record struct CampaignItemIngestResponseItemObjectResponseBodyResult : IStringEnum
{
    public static readonly CampaignItemIngestResponseItemObjectResponseBodyResult Created = new(
        Values.Created
    );

    public static readonly CampaignItemIngestResponseItemObjectResponseBodyResult AlreadyPresent =
        new(Values.AlreadyPresent);

    public static readonly CampaignItemIngestResponseItemObjectResponseBodyResult UnresolvedVin =
        new(Values.UnresolvedVin);

    public static readonly CampaignItemIngestResponseItemObjectResponseBodyResult UnresolvedAssetId =
        new(Values.UnresolvedAssetId);

    public static readonly CampaignItemIngestResponseItemObjectResponseBodyResult Invalid = new(
        Values.Invalid
    );

    public static readonly CampaignItemIngestResponseItemObjectResponseBodyResult OverCap = new(
        Values.OverCap
    );

    public CampaignItemIngestResponseItemObjectResponseBodyResult(string value)
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
    public static CampaignItemIngestResponseItemObjectResponseBodyResult FromCustom(string value)
    {
        return new CampaignItemIngestResponseItemObjectResponseBodyResult(value);
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
        CampaignItemIngestResponseItemObjectResponseBodyResult value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        CampaignItemIngestResponseItemObjectResponseBodyResult value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        CampaignItemIngestResponseItemObjectResponseBodyResult value
    ) => value.Value;

    public static explicit operator CampaignItemIngestResponseItemObjectResponseBodyResult(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Created = "created";

        public const string AlreadyPresent = "alreadyPresent";

        public const string UnresolvedVin = "unresolvedVin";

        public const string UnresolvedAssetId = "unresolvedAssetId";

        public const string Invalid = "invalid";

        public const string OverCap = "overCap";
    }
}
