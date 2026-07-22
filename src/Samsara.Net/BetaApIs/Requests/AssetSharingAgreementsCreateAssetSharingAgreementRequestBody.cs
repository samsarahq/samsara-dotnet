using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record AssetSharingAgreementsCreateAssetSharingAgreementRequestBody
{
    /// <summary>
    /// Defines where the gateways will be located.  Valid values: `provider`, `recipient`
    /// </summary>
    [JsonPropertyName("operator")]
    public required AssetSharingAgreementsCreateAssetSharingAgreementRequestBodyOperator Operator { get; set; }

    /// <summary>
    /// List of data packages the provider will see.
    /// </summary>
    [JsonPropertyName("providerDataPackages")]
    public IEnumerable<AssetSharingAgreementsCreateAssetSharingAgreementRequestBodyProviderDataPackagesItem> ProviderDataPackages { get; set; } =
        new List<AssetSharingAgreementsCreateAssetSharingAgreementRequestBodyProviderDataPackagesItem>();

    /// <summary>
    /// List of data packages the recipient will see.
    /// </summary>
    [JsonPropertyName("recipientDataPackages")]
    public IEnumerable<AssetSharingAgreementsCreateAssetSharingAgreementRequestBodyRecipientDataPackagesItem> RecipientDataPackages { get; set; } =
        new List<AssetSharingAgreementsCreateAssetSharingAgreementRequestBodyRecipientDataPackagesItem>();

    /// <summary>
    /// The ID of the recipient organization.
    /// </summary>
    [JsonPropertyName("recipientOrganizationId")]
    public required string RecipientOrganizationId { get; set; }

    /// <summary>
    /// The display name to use for the recipient organization.
    /// </summary>
    [JsonPropertyName("recipientOrganizationName")]
    public required string RecipientOrganizationName { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
