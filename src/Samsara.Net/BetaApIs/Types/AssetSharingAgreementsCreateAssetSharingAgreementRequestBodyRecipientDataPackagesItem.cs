using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[JsonConverter(
    typeof(StringEnumSerializer<AssetSharingAgreementsCreateAssetSharingAgreementRequestBodyRecipientDataPackagesItem>)
)]
[Serializable]
public readonly record struct AssetSharingAgreementsCreateAssetSharingAgreementRequestBodyRecipientDataPackagesItem
    : IStringEnum
{
    public static readonly AssetSharingAgreementsCreateAssetSharingAgreementRequestBodyRecipientDataPackagesItem Safety =
        new(Values.Safety);

    public static readonly AssetSharingAgreementsCreateAssetSharingAgreementRequestBodyRecipientDataPackagesItem Telematics =
        new(Values.Telematics);

    public static readonly AssetSharingAgreementsCreateAssetSharingAgreementRequestBodyRecipientDataPackagesItem Location =
        new(Values.Location);

    public static readonly AssetSharingAgreementsCreateAssetSharingAgreementRequestBodyRecipientDataPackagesItem Maintenance =
        new(Values.Maintenance);

    public static readonly AssetSharingAgreementsCreateAssetSharingAgreementRequestBodyRecipientDataPackagesItem Reefer =
        new(Values.Reefer);

    public static readonly AssetSharingAgreementsCreateAssetSharingAgreementRequestBodyRecipientDataPackagesItem All =
        new(Values.All);

    public AssetSharingAgreementsCreateAssetSharingAgreementRequestBodyRecipientDataPackagesItem(
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
    public static AssetSharingAgreementsCreateAssetSharingAgreementRequestBodyRecipientDataPackagesItem FromCustom(
        string value
    )
    {
        return new AssetSharingAgreementsCreateAssetSharingAgreementRequestBodyRecipientDataPackagesItem(
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
        AssetSharingAgreementsCreateAssetSharingAgreementRequestBodyRecipientDataPackagesItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AssetSharingAgreementsCreateAssetSharingAgreementRequestBodyRecipientDataPackagesItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        AssetSharingAgreementsCreateAssetSharingAgreementRequestBodyRecipientDataPackagesItem value
    ) => value.Value;

    public static explicit operator AssetSharingAgreementsCreateAssetSharingAgreementRequestBodyRecipientDataPackagesItem(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Safety = "safety";

        public const string Telematics = "telematics";

        public const string Location = "location";

        public const string Maintenance = "maintenance";

        public const string Reefer = "reefer";

        public const string All = "all";
    }
}
