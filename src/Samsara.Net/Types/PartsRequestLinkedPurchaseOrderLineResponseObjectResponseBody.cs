using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A purchase order line that orders part of the requested quantity.
/// </summary>
[Serializable]
public record PartsRequestLinkedPurchaseOrderLineResponseObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Quantity ordered on the purchase order line.
    /// </summary>
    [JsonPropertyName("orderedQuantity")]
    public required double OrderedQuantity { get; set; }

    /// <summary>
    /// Samsara ID of the part on the purchase order line.
    /// </summary>
    [JsonPropertyName("partSamsaraId")]
    public required string PartSamsaraId { get; set; }

    /// <summary>
    /// Number of the purchase order.
    /// </summary>
    [JsonPropertyName("purchaseOrderNumber")]
    public string? PurchaseOrderNumber { get; set; }

    /// <summary>
    /// Quantity received on the purchase order line.
    /// </summary>
    [JsonPropertyName("receivedQuantity")]
    public required double ReceivedQuantity { get; set; }

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
