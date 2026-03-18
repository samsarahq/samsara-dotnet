using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Per-item result for a single Safety Event in the batch.
/// </summary>
[Serializable]
public record PatchSafetyEventsResponseItemResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("data")]
    public required PatchSafetyEventsResponseItemDataResponseBody Data { get; set; }

    /// <summary>
    /// HTTP status code for this item. Always 202 on success.
    /// </summary>
    [JsonPropertyName("status")]
    public required long Status { get; set; }

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
