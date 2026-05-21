using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Partial hub location changes for a place. When present on PATCH, applies upserts and removals; omitted leaves hub rows unchanged.
/// </summary>
[Serializable]
public record PatchPlaceHubLocationsBodyRequestBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Hub location ids to remove.
    /// </summary>
    [JsonPropertyName("removeHubLocationIds")]
    public IEnumerable<string>? RemoveHubLocationIds { get; set; }

    /// <summary>
    /// Hub rows to create or update.
    /// </summary>
    [JsonPropertyName("upsert")]
    public IEnumerable<PatchPlaceHubLocationUpsertBodyRequestBody>? Upsert { get; set; }

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
