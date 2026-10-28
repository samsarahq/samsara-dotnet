using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Quote line. Omit id for a new line. Supply amount, or quantity and unitRate together, or both representations when they agree after rounding the extended amount once to cents.
/// </summary>
[Serializable]
public record MaintenanceEstimateLineInputRequestBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("amount")]
    public MaintenanceEstimateMoneyRequestBody? Amount { get; set; }

    /// <summary>
    /// Optional classification of the entire line. Labor assigns all cost to labor; parts assigns all cost to parts. Omission leaves a new or replacement line unclassified; it does not infer a type from description.  Valid values: `labor`, `parts`
    /// </summary>
    [JsonPropertyName("costType")]
    public MaintenanceEstimateLineInputRequestBodyCostType? CostType { get; set; }

    /// <summary>
    /// Vendor's quote text, at most 2000 Unicode characters.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Existing line ID when retaining a line during PATCH.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Quantity or labor hours, greater than zero with at most two fractional digits. When supplied, unitRate is also required. Omitted when actual quantity is unknown.
    /// </summary>
    [JsonPropertyName("quantity")]
    public double? Quantity { get; set; }

    /// <summary>
    /// Associated service-task instance belonging to this WO.
    /// </summary>
    [JsonPropertyName("serviceTaskId")]
    public string? ServiceTaskId { get; set; }

    [JsonPropertyName("unitRate")]
    public MaintenanceEstimateUnitRateRequestBody? UnitRate { get; set; }

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
