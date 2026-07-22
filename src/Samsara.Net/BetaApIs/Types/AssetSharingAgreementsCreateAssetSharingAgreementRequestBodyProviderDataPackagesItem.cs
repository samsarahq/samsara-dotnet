using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[JsonConverter(
    typeof(StringEnumSerializer<AssetSharingAgreementsCreateAssetSharingAgreementRequestBodyProviderDataPackagesItem>)
)]
[Serializable]
public readonly record struct AssetSharingAgreementsCreateAssetSharingAgreementRequestBodyProviderDataPackagesItem
    : IStringEnum
{
    public static readonly AssetSharingAgreementsCreateAssetSharingAgreementRequestBodyProviderDataPackagesItem Safety =
        new(Values.Safety);

    public static readonly AssetSharingAgreementsCreateAssetSharingAgreementRequestBodyProviderDataPackagesItem Telematics =
        new(Values.Telematics);

    public static readonly AssetSharingAgreementsCreateAssetSharingAgreementRequestBodyProviderDataPackagesItem Location =
        new(Values.Location);

    public static readonly AssetSharingAgreementsCreateAssetSharingAgreementRequestBodyProviderDataPackagesItem Maintenance =
        new(Values.Maintenance);

    public static readonly AssetSharingAgreementsCreateAssetSharingAgreementRequestBodyProviderDataPackagesItem Reefer =
        new(Values.Reefer);

    public static readonly AssetSharingAgreementsCreateAssetSharingAgreementRequestBodyProviderDataPackagesItem All =
        new(Values.All);

    public AssetSharingAgreementsCreateAssetSharingAgreementRequestBodyProviderDataPackagesItem(
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
    public static AssetSharingAgreementsCreateAssetSharingAgreementRequestBodyProviderDataPackagesItem FromCustom(
        string value
    )
    {
        return new AssetSharingAgreementsCreateAssetSharingAgreementRequestBodyProviderDataPackagesItem(
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
        AssetSharingAgreementsCreateAssetSharingAgreementRequestBodyProviderDataPackagesItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AssetSharingAgreementsCreateAssetSharingAgreementRequestBodyProviderDataPackagesItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        AssetSharingAgreementsCreateAssetSharingAgreementRequestBodyProviderDataPackagesItem value
    ) => value.Value;

    public static explicit operator AssetSharingAgreementsCreateAssetSharingAgreementRequestBodyProviderDataPackagesItem(
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
