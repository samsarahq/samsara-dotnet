using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// PartDefinition object
/// </summary>
[Serializable]
public record EntityListPartsTypeResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Time when the part was archived.
    /// </summary>
    [JsonPropertyName("archivedAtTime")]
    public string? ArchivedAtTime { get; set; }

    /// <summary>
    /// Barcode associated with the part definition.
    /// </summary>
    [JsonPropertyName("barcodeString")]
    public string? BarcodeString { get; set; }

    /// <summary>
    /// Category of the part definition.
    /// </summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary>
    /// Time when the part was created.
    /// </summary>
    [JsonPropertyName("createdAtTime")]
    public string? CreatedAtTime { get; set; }

    /// <summary>
    /// Time when the part was deleted.
    /// </summary>
    [JsonPropertyName("deletedAtTime")]
    public string? DeletedAtTime { get; set; }

    /// <summary>
    /// Description of the part definition.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Unique identifier for the part.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Whether inventory tracking is enabled for this part.
    /// </summary>
    [JsonPropertyName("isInventoryTracked")]
    public bool? IsInventoryTracked { get; set; }

    /// <summary>
    /// Manufacturer-supplied part number.
    /// </summary>
    [JsonPropertyName("manufacturerPartNumber")]
    public string? ManufacturerPartNumber { get; set; }

    /// <summary>
    /// Name of the part definition.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Customer-visible part number for the part.
    /// </summary>
    [JsonPropertyName("partNumber")]
    public string? PartNumber { get; set; }

    /// <summary>
    /// Status of the part.
    /// </summary>
    [JsonPropertyName("partStatus")]
    public string? PartStatus { get; set; }

    /// <summary>
    /// Subcategory of the part definition.
    /// </summary>
    [JsonPropertyName("subcategory")]
    public string? Subcategory { get; set; }

    [JsonPropertyName("unitCost")]
    public ListPartsEntityPartDefinitionMoneyTypeResponseBody? UnitCost { get; set; }

    /// <summary>
    /// Unit of measure for the part.
    /// </summary>
    [JsonPropertyName("unitOfMeasureType")]
    public string? UnitOfMeasureType { get; set; }

    /// <summary>
    /// Time when the part was last updated.
    /// </summary>
    [JsonPropertyName("updatedAtTime")]
    public string? UpdatedAtTime { get; set; }

    /// <summary>
    /// VMRS code associated with the part definition.
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
