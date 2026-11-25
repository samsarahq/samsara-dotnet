using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Work Order Part Instance object.
/// </summary>
[Serializable]
public record PartInstanceObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The cost of one unit of the part in cents. If not provided, the part defined cost will be used.
    /// </summary>
    [JsonPropertyName("costCentsOverride")]
    public long? CostCentsOverride { get; set; }

    /// <summary>
    /// ID of the part instance.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// ID of the maintenance site that stocks this part. Uses the same ID as GET /maintenance/sites. This is not the Places API placeId. Omitted when the part has no maintenance site, and unless total part quantity is enabled for the organization.
    /// </summary>
    [JsonPropertyName("maintenanceSiteId")]
    public string? MaintenanceSiteId { get; set; }

    /// <summary>
    /// ID of the part definition.
    /// </summary>
    [JsonPropertyName("partId")]
    public required string PartId { get; set; }

    /// <summary>
    /// The stock-backed quantity of the part in the part's predefined unit of measure.
    /// </summary>
    [JsonPropertyName("quantity")]
    public required double Quantity { get; set; }

    /// <summary>
    /// Total quantity needed for the part, in the part's predefined unit of measure, including any shortage. Omitted unless total part quantity is enabled for the organization. A shortage request is reconciled asynchronously after the work order is saved.
    /// </summary>
    [JsonPropertyName("requestedQuantity")]
    public double? RequestedQuantity { get; set; }

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
