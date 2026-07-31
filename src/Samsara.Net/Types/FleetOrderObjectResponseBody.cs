using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A canonical customer order.
/// </summary>
[Serializable]
public record FleetOrderObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Creation timestamp in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("createdAtTime")]
    public required DateTime CreatedAtTime { get; set; }

    /// <summary>
    /// Order-specific customer metadata.
    /// </summary>
    [JsonPropertyName("customerProperties")]
    public IEnumerable<FleetOrderCustomerPropertyObjectResponseBody> CustomerProperties { get; set; } =
        new List<FleetOrderCustomerPropertyObjectResponseBody>();

    /// <summary>
    /// Org-scoped external identifiers.
    /// </summary>
    [JsonPropertyName("externalIds")]
    public FleetOrderObjectResponseBodyExternalIds? ExternalIds { get; set; }

    /// <summary>
    /// Samsara-generated canonical order UUID.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Human-readable order label.
    /// </summary>
    [JsonPropertyName("samsaraCustomerOrderName")]
    public string? SamsaraCustomerOrderName { get; set; }

    /// <summary>
    /// Live order tasks.
    /// </summary>
    [JsonPropertyName("tasks")]
    public IEnumerable<FleetOrderTaskObjectResponseBody> Tasks { get; set; } =
        new List<FleetOrderTaskObjectResponseBody>();

    /// <summary>
    /// Last update timestamp in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("updatedAtTime")]
    public required DateTime UpdatedAtTime { get; set; }

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
