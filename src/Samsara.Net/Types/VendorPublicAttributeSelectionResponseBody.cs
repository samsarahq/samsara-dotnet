using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Asset attribute values the vendor can service.
/// </summary>
[Serializable]
public record VendorPublicAttributeSelectionResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Asset attribute ID.
    /// </summary>
    [JsonPropertyName("attributeId")]
    public required string AttributeId { get; set; }

    /// <summary>
    /// Selected values.
    /// </summary>
    [JsonPropertyName("values")]
    public IEnumerable<VendorPublicAttributeValueResponseBody> Values { get; set; } =
        new List<VendorPublicAttributeValueResponseBody>();

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
