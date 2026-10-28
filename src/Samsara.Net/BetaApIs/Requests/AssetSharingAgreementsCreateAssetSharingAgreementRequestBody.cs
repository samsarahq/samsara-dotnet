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
    /// Party whose Asset Sharing license supports the agreement. Defaults to the creator when the flexible operating model is enabled. Otherwise, the provider pays; omit this field or specify provider. Specifying recipient requires the flexible operating model to be enabled.  Valid values: `provider`, `recipient`
    /// </summary>
    [JsonPropertyName("payer")]
    public AssetSharingAgreementsCreateAssetSharingAgreementRequestBodyPayer? Payer { get; set; }

    /// <summary>
    /// List of data packages the provider will see.
    /// </summary>
    [JsonPropertyName("providerDataPackages")]
    public IEnumerable<AssetSharingAgreementsCreateAssetSharingAgreementRequestBodyProviderDataPackagesItem> ProviderDataPackages { get; set; } =
        new List<AssetSharingAgreementsCreateAssetSharingAgreementRequestBodyProviderDataPackagesItem>();

    /// <summary>
    /// ID of the organization that owns the assets. Defaults to the caller's organization. Recipient-initiated agreements require the flexible operating model to be enabled.
    /// </summary>
    [JsonPropertyName("providerOrganizationId")]
    public string? ProviderOrganizationId { get; set; }

    /// <summary>
    /// Display name for the provider. Required when the caller is the recipient; the caller's own organization name is resolved automatically.
    /// </summary>
    [JsonPropertyName("providerOrganizationName")]
    public string? ProviderOrganizationName { get; set; }

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
    /// Display name for the recipient. Required when the caller is the provider; the caller's own organization name is resolved automatically.
    /// </summary>
    [JsonPropertyName("recipientOrganizationName")]
    public string? RecipientOrganizationName { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
