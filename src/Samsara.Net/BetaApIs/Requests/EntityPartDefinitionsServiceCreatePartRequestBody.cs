using System.Text.Json.Serialization;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record EntityPartDefinitionsServiceCreatePartRequestBody
{
    /// <summary>
    /// Barcode associated with the part definition.
    /// </summary>
    [JsonPropertyName("barcodeString")]
    public string? BarcodeString { get; set; }

    /// <summary>
    /// Description of the part definition.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

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
    public required string PartNumber { get; set; }

    [JsonPropertyName("unitCost")]
    public CreatePartEntityPartDefinitionMoneyInputTypeRequestBody? UnitCost { get; set; }

    /// <summary>
    /// VMRS code associated with the part definition.
    /// </summary>
    [JsonPropertyName("vmrsCode")]
    public string? VmrsCode { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
