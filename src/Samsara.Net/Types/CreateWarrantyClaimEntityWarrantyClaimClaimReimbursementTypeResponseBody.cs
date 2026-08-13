using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// CreateWarrantyClaimEntityWarrantyClaimClaimReimbursement object
/// </summary>
[Serializable]
public record CreateWarrantyClaimEntityWarrantyClaimClaimReimbursementTypeResponseBody
    : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("reimbursement")]
    public CreateWarrantyClaimEntityWarrantyClaimMoneyTypeResponseBody? Reimbursement { get; set; }

    /// <summary>
    /// Work order the reimbursement is applied to.
    /// </summary>
    [JsonPropertyName("workOrderId")]
    public string? WorkOrderId { get; set; }

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
