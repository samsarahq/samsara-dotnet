using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// VendorAssetAttributeSelection object
/// </summary>
[Serializable]
public record UpdateVendorEntityVendorVendorAssetAttributeSelectionInputTypeRequestBody
    : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// ID of an asset-scoped preset attribute.
    /// </summary>
    [JsonPropertyName("attributeId")]
    public required string AttributeId { get; set; }

    /// <summary>
    /// Selected values. At most 100 values per attribute.
    /// </summary>
    [JsonPropertyName("values")]
    public IEnumerable<UpdateVendorEntityVendorVendorAssetAttributeValueInputTypeRequestBody> Values { get; set; } =
        new List<UpdateVendorEntityVendorVendorAssetAttributeValueInputTypeRequestBody>();

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
