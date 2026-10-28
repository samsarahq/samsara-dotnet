using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// One priced line from the quote.
/// </summary>
[Serializable]
public record MaintenanceEstimateLineItemResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("amount")]
    public required MaintenanceEstimateMoneyResponseBody Amount { get; set; }

    /// <summary>
    /// Whether the entire line is labor or parts. Omitted when classification is absent or mixed; unknown represents an unrecognized classification. No classification is inferred from description.  Valid values: `unknown`, `labor`, `parts`
    /// </summary>
    [JsonPropertyName("costType")]
    public MaintenanceEstimateLineItemResponseBodyCostType? CostType { get; set; }

    /// <summary>
    /// Vendor quote text; retained even when serviceTaskId is supplied. Maximum 2000 Unicode characters.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Server-generated line ID.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Quantity or labor hours, greater than zero with at most two fractional digits. When supplied, unitRate is also required. Omitted when actual quantity is unknown.
    /// </summary>
    [JsonPropertyName("quantity")]
    public double? Quantity { get; set; }

    /// <summary>
    /// Associated WO service-task instance ID; not a task catalog ID.
    /// </summary>
    [JsonPropertyName("serviceTaskId")]
    public string? ServiceTaskId { get; set; }

    [JsonPropertyName("unitRate")]
    public MaintenanceEstimateUnitRateResponseBody? UnitRate { get; set; }

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
