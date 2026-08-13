using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// CreateWarrantyEntityWarrantyWarrantyCoverageItem object
/// </summary>
[Serializable]
public record CreateWarrantyEntityWarrantyWarrantyCoverageItemTypeResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Identifier of the covered item. For a service task item this is the service task definition key. For a VMRS code item supply vmrsCode instead, or this internal VMRS code ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Kind of covered item, indicating how the ID should be interpreted (VMRS code or service task).
    /// </summary>
    [JsonPropertyName("itemType")]
    public string? ItemType { get; set; }

    /// <summary>
    /// Dotted VMRS code path (e.g. 034-005-001). Use with itemType vmrsCode instead of id.
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
