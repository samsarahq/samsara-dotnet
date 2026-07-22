using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Data Sharing Agreement response object.
/// </summary>
[Serializable]
public record AssetSharingAgreementResponseObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Time the agreement was accepted, in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("acceptedAtTime")]
    public string? AcceptedAtTime { get; set; }

    /// <summary>
    /// User ID who accepted the agreement (visible only to recipient).
    /// </summary>
    [JsonPropertyName("acceptedByUserId")]
    public string? AcceptedByUserId { get; set; }

    /// <summary>
    /// Time the agreement was canceled, in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("canceledAtTime")]
    public string? CanceledAtTime { get; set; }

    /// <summary>
    /// Party that canceled the agreement.  Valid values: `provider`, `recipient`
    /// </summary>
    [JsonPropertyName("canceledByParty")]
    public AssetSharingAgreementResponseObjectResponseBodyCanceledByParty? CanceledByParty { get; set; }

    /// <summary>
    /// User ID who canceled the agreement (visible only to the canceling party).
    /// </summary>
    [JsonPropertyName("canceledByUserId")]
    public string? CanceledByUserId { get; set; }

    /// <summary>
    /// Time the agreement was created, in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("createdAtTime")]
    public required string CreatedAtTime { get; set; }

    /// <summary>
    /// User ID in provider org who created the agreement.
    /// </summary>
    [JsonPropertyName("createdByUserId")]
    public string? CreatedByUserId { get; set; }

    /// <summary>
    /// User ID in provider org who soft-deleted the agreement.
    /// </summary>
    [JsonPropertyName("deletedByUserId")]
    public string? DeletedByUserId { get; set; }

    /// <summary>
    /// Unique identifier for the agreement.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Defines where the gateways will be located.  Valid values: `provider`, `recipient`
    /// </summary>
    [JsonPropertyName("operator")]
    public required AssetSharingAgreementResponseObjectResponseBodyOperator Operator { get; set; }

    /// <summary>
    /// List of data packages the provider will see.
    /// </summary>
    [JsonPropertyName("providerDataPackages")]
    public IEnumerable<AssetSharingAgreementResponseObjectResponseBodyProviderDataPackagesItem> ProviderDataPackages { get; set; } =
        new List<AssetSharingAgreementResponseObjectResponseBodyProviderDataPackagesItem>();

    /// <summary>
    /// ID of the organization that owns the assets shared under the agreement.
    /// </summary>
    [JsonPropertyName("providerOrganizationId")]
    public required string ProviderOrganizationId { get; set; }

    /// <summary>
    /// List of data packages the recipient will see.
    /// </summary>
    [JsonPropertyName("recipientDataPackages")]
    public IEnumerable<AssetSharingAgreementResponseObjectResponseBodyRecipientDataPackagesItem> RecipientDataPackages { get; set; } =
        new List<AssetSharingAgreementResponseObjectResponseBodyRecipientDataPackagesItem>();

    /// <summary>
    /// ID of the organization that rents the assets from the provider.
    /// </summary>
    [JsonPropertyName("recipientOrganizationId")]
    public required string RecipientOrganizationId { get; set; }

    /// <summary>
    /// Time the agreement was rejected, in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("rejectedAtTime")]
    public string? RejectedAtTime { get; set; }

    /// <summary>
    /// User ID who rejected the agreement (visible only to recipient).
    /// </summary>
    [JsonPropertyName("rejectedByUserId")]
    public string? RejectedByUserId { get; set; }

    /// <summary>
    /// The status of the agreement.  Valid values: `pending`, `accepted`, `rejected`, `canceled`
    /// </summary>
    [JsonPropertyName("status")]
    public required AssetSharingAgreementResponseObjectResponseBodyStatus Status { get; set; }

    /// <summary>
    /// Time the agreement was last updated, in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("updatedAtTime")]
    public required string UpdatedAtTime { get; set; }

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
