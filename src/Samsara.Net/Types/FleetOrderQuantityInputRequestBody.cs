using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A labelled quantity for an order task.
/// </summary>
[Serializable]
public record FleetOrderQuantityInputRequestBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Optional capacity UUID for the task hub.
    /// </summary>
    [JsonPropertyName("capacityId")]
    public string? CapacityId { get; set; }

    /// <summary>
    /// Human-readable quantity label.
    /// </summary>
    [JsonPropertyName("label")]
    public required string Label { get; set; }

    /// <summary>
    /// Finite, non-negative quantity value.
    /// </summary>
    [JsonPropertyName("value")]
    public required double Value { get; set; }

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
