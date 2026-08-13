using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// ListWarrantyClaimsEntityWarrantyClaimWarrantyClaimPart object
/// </summary>
[Serializable]
public record ListWarrantyClaimsEntityWarrantyClaimWarrantyClaimPartTypeResponseBody
    : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("cost")]
    public ListWarrantyClaimsEntityWarrantyClaimMoneyTypeResponseBody? Cost { get; set; }

    /// <summary>
    /// Free-text part description.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// ID of the part definition being claimed.
    /// </summary>
    [JsonPropertyName("partDefinitionId")]
    public string? PartDefinitionId { get; set; }

    /// <summary>
    /// Specific part-instance ID.
    /// </summary>
    [JsonPropertyName("partId")]
    public string? PartId { get; set; }

    /// <summary>
    /// Quantity claimed.
    /// </summary>
    [JsonPropertyName("quantity")]
    public long? Quantity { get; set; }

    /// <summary>
    /// Service task the part belongs to.
    /// </summary>
    [JsonPropertyName("serviceTaskId")]
    public string? ServiceTaskId { get; set; }

    /// <summary>
    /// Work order the part cost originated from.
    /// </summary>
    [JsonPropertyName("sourceWorkOrderId")]
    public string? SourceWorkOrderId { get; set; }

    /// <summary>
    /// Dotted VMRS code path (e.g. 034-005-001) associated with this part line.
    /// </summary>
    [JsonPropertyName("vmrsCode")]
    public string? VmrsCode { get; set; }

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
