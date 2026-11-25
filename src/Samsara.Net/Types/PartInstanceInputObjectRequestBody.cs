using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Work Order Part Instance object.
/// </summary>
[Serializable]
public record PartInstanceInputObjectRequestBody : IJsonOnDeserialized
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
    /// ID of the part instance. Only set if updating an existing part instance.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// ID of the maintenance site that stocks this part. Uses the same ID as GET /maintenance/sites. This is not the Places API placeId. Accepted only when total part quantity is enabled for the organization.
    /// </summary>
    [JsonPropertyName("maintenanceSiteId")]
    public string? MaintenanceSiteId { get; set; }

    /// <summary>
    /// ID of the part definition.
    /// </summary>
    [JsonPropertyName("partId")]
    public required string PartId { get; set; }

    /// <summary>
    /// The stock quantity of the part in the part's predefined unit of measure. When requestedQuantity is also sent, quantity is the stock amount and requestedQuantity is the total demand. Required when requestedQuantity is omitted.
    /// </summary>
    [JsonPropertyName("quantity")]
    public double? Quantity { get; set; }

    /// <summary>
    /// Total quantity needed for the part, in the part's predefined unit of measure, including any shortage. When both fields are sent, this field is the total demand and quantity is the stock amount. Send 0 for zero demand. A shortage request is reconciled asynchronously after the work order is saved. Accepted only when total part quantity is enabled for the organization.
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
