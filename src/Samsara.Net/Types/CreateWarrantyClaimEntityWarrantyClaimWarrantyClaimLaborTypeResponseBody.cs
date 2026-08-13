using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// CreateWarrantyClaimEntityWarrantyClaimWarrantyClaimLabor object
/// </summary>
[Serializable]
public record CreateWarrantyClaimEntityWarrantyClaimWarrantyClaimLaborTypeResponseBody
    : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("cost")]
    public CreateWarrantyClaimEntityWarrantyClaimMoneyTypeResponseBody? Cost { get; set; }

    /// <summary>
    /// Free-text labor description.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Service task the labor belongs to.
    /// </summary>
    [JsonPropertyName("serviceTaskId")]
    public string? ServiceTaskId { get; set; }

    /// <summary>
    /// Work order the labor cost originated from.
    /// </summary>
    [JsonPropertyName("sourceWorkOrderId")]
    public string? SourceWorkOrderId { get; set; }

    /// <summary>
    /// Dotted VMRS code path (e.g. 034-005-001) associated with this labor line.
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
