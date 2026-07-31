using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A canonical order to upsert and attach to the containing route stop.
/// </summary>
[Serializable]
public record RouteStopOrderUpsertInputRequestBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Order-specific customer metadata.
    /// </summary>
    [JsonPropertyName("customerProperties")]
    public IEnumerable<FleetOrderCustomerPropertyObjectRequestBody>? CustomerProperties { get; set; }

    /// <summary>
    /// Org-scoped external identifiers.
    /// </summary>
    [JsonPropertyName("externalIds")]
    public RouteStopOrderUpsertInputRequestBodyExternalIds? ExternalIds { get; set; }

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
    /// The task to upsert and attach to the containing stop.
    /// </summary>
    [JsonPropertyName("tasks")]
    public IEnumerable<FleetOrderTaskUpsertInputRequestBody> Tasks { get; set; } =
        new List<FleetOrderTaskUpsertInputRequestBody>();

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
