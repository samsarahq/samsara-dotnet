using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// WarrantyClaimStatusHistory object
/// </summary>
[Serializable]
public record CreateWarrantyClaimEntityWarrantyClaimWarrantyClaimStatusHistoryTypeResponseBody
    : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// When the transition occurred.
    /// </summary>
    [JsonPropertyName("happenedAtTime")]
    public string? HappenedAtTime { get; set; }

    /// <summary>
    /// The status the claim moved into.  Valid values: `unknown`, `created`, `submitted`, `inReview`, `approved`, `rejected`, `resubmitted`, `reimbursed`
    /// </summary>
    [JsonPropertyName("status")]
    public CreateWarrantyClaimEntityWarrantyClaimWarrantyClaimStatusHistoryTypeResponseBodyStatus? Status { get; set; }

    /// <summary>
    /// ID of the user who made the change.
    /// </summary>
    [JsonPropertyName("userId")]
    public string? UserId { get; set; }

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
