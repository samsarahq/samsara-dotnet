using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A labelled task quantity.
/// </summary>
[Serializable]
public record FleetOrderQuantityObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Capacity UUID when this quantity uses a configured capacity.
    /// </summary>
    [JsonPropertyName("capacityId")]
    public string? CapacityId { get; set; }

    /// <summary>
    /// Opaque quantity UUID.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Human-readable quantity label.
    /// </summary>
    [JsonPropertyName("label")]
    public required string Label { get; set; }

    /// <summary>
    /// Quantity value.
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
