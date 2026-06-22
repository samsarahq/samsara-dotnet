using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Targeted route-planning updates on PATCH.
/// </summary>
[Serializable]
public record PlaceRoutingPatchInputRequestBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Hub ids to delete. Omitted hubs are unchanged. Removing an unknown hub id is a no-op.
    /// </summary>
    [JsonPropertyName("removeHubIds")]
    public IEnumerable<string>? RemoveHubIds { get; set; }

    /// <summary>
    /// Rows to create or update by hubId. Each entry requires hubId; (placeId, hubId) must be unique within upsert.
    /// </summary>
    [JsonPropertyName("upsert")]
    public IEnumerable<PlaceRoutingInputRequestBody>? Upsert { get; set; }

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
