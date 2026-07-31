using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A canonical order to create or update in an atomic standalone batch.
/// </summary>
[Serializable]
public record FleetOrderBatchUpsertInputRequestBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Order-specific customer metadata.
    /// </summary>
    [JsonPropertyName("customerProperties")]
    public IEnumerable<FleetOrderBatchCustomerPropertyInputRequestBody>? CustomerProperties { get; set; }

    /// <summary>
    /// Org-scoped external identifiers.
    /// </summary>
    [JsonPropertyName("externalIds")]
    public FleetOrderBatchUpsertInputRequestBodyExternalIds? ExternalIds { get; set; }

    /// <summary>
    /// Existing Samsara order UUID. Required unless externalIds is supplied.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Human-readable order label.
    /// </summary>
    [JsonPropertyName("samsaraCustomerOrderName")]
    public string? SamsaraCustomerOrderName { get; set; }

    /// <summary>
    /// Existing task IDs to retire.
    /// </summary>
    [JsonPropertyName("taskIdsToRemove")]
    public IEnumerable<string>? TaskIdsToRemove { get; set; }

    /// <summary>
    /// Tasks to create or update. Omitted existing tasks remain live.
    /// </summary>
    [JsonPropertyName("tasks")]
    public IEnumerable<FleetOrderBatchTaskUpsertInputRequestBody>? Tasks { get; set; }

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
