using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Per-capacity order service time entry for a hub location row.
/// </summary>
[Serializable]
public record PlaceHubLocationCapacityServiceTimeInputRequestBody : IJsonOnDeserialized
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
    /// Service time in seconds.
    /// </summary>
    [JsonPropertyName("serviceTimeSeconds")]
    public required long ServiceTimeSeconds { get; set; }

    /// <summary>
    /// Additional service time per quantity unit.
    /// </summary>
    [JsonPropertyName("serviceTimeSecondsPerQuantityUnit")]
    public required double ServiceTimeSecondsPerQuantityUnit { get; set; }

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
