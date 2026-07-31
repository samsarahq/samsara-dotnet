using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A service window to create or update.
/// </summary>
[Serializable]
public record FleetOrderServiceWindowUpsertInputRequestBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Service window end in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("endTime")]
    public DateTime? EndTime { get; set; }

    /// <summary>
    /// Existing service window UUID. Omit to create a window.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Service window start in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("startTime")]
    public DateTime? StartTime { get; set; }

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
