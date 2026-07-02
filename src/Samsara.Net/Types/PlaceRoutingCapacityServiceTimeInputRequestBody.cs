using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Per-capacity order service time for a routing row.
/// </summary>
[Serializable]
public record PlaceRoutingCapacityServiceTimeInputRequestBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Capacity UUID.
    /// </summary>
    [JsonPropertyName("capacityId")]
    public required string CapacityId { get; set; }

    /// <summary>
    /// Quantity units per service time chunk.
    /// </summary>
    [JsonPropertyName("quantityPerServiceTime")]
    public required double QuantityPerServiceTime { get; set; }

    /// <summary>
    /// Service time in seconds.
    /// </summary>
    [JsonPropertyName("serviceTimeSeconds")]
    public required long ServiceTimeSeconds { get; set; }

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
