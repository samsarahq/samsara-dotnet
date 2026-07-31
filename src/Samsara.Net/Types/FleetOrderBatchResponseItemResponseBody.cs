using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Result for one atomic batch input.
/// </summary>
[Serializable]
public record FleetOrderBatchResponseItemResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("data")]
    public FleetOrderObjectResponseBody? Data { get; set; }

    /// <summary>
    /// Failure message.
    /// </summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// HTTP-style status for this input.
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
