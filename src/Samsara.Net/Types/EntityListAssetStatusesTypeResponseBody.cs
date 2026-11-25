using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// AssetStatus object
/// </summary>
[Serializable]
public record EntityListAssetStatusesTypeResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("asset")]
    public EntityListAssetStatusesAssetRefTypeResponseBody? Asset { get; set; }

    /// <summary>
    /// Note on the most recent status change. On update, required when the status being entered requires a comment on entry, or the status being left requires a comment on exit.
    /// </summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    [JsonPropertyName("lastChangedBy")]
    public ListAssetStatusesEntityAssetStatusAssetStatusActorTypeResponseBody? LastChangedBy { get; set; }

    [JsonPropertyName("status")]
    public ListAssetStatusesEntityAssetStatusAssetStatusRefTypeResponseBody? Status { get; set; }

    /// <summary>
    /// When the asset entered its current status.
    /// </summary>
    [JsonPropertyName("statusSinceTime")]
    public string? StatusSinceTime { get; set; }

    /// <summary>
    /// Stable ID of the status the asset is in. On update, the status to move the asset into.
    /// </summary>
    [JsonPropertyName("statusUuid")]
    public string? StatusUuid { get; set; }

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
