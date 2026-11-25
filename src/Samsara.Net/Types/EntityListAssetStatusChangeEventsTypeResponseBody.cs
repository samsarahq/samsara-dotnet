using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// AssetStatusChangeEvent object
/// </summary>
[Serializable]
public record EntityListAssetStatusChangeEventsTypeResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("actor")]
    public ListAssetStatusChangeEventsEntityAssetStatusChangeEventAssetStatusChangeEventActorTypeResponseBody? Actor { get; set; }

    [JsonPropertyName("asset")]
    public EntityListAssetStatusChangeEventsAssetRefTypeResponseBody? Asset { get; set; }

    /// <summary>
    /// Unique ID of this status change.
    /// </summary>
    [JsonPropertyName("changeUuid")]
    public string? ChangeUuid { get; set; }

    /// <summary>
    /// Note recorded with the change.
    /// </summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>
    /// Whether the entry was backfilled from a historical import rather than recorded live.
    /// </summary>
    [JsonPropertyName("isImported")]
    public bool? IsImported { get; set; }

    [JsonPropertyName("newStatus")]
    public ListAssetStatusChangeEventsEntityAssetStatusChangeEventAssetStatusChangeEventStatusTypeResponseBody? NewStatus { get; set; }

    /// <summary>
    /// When the status change happened.
    /// </summary>
    [JsonPropertyName("occurredAtTime")]
    public string? OccurredAtTime { get; set; }

    [JsonPropertyName("previousStatus")]
    public ListAssetStatusChangeEventsEntityAssetStatusChangeEventAssetStatusChangeEventStatusTypeResponseBody? PreviousStatus { get; set; }

    /// <summary>
    /// Where the change was made from.  Valid values: `unknown`, `dashboard`, `csv`, `automation`, `api`, `mobile`, `shim`, `backfill`, `system`, `csvHistoricalImport`
    /// </summary>
    [JsonPropertyName("source")]
    public EntityListAssetStatusChangeEventsTypeResponseBodySource? Source { get; set; }

    [JsonPropertyName("sourceEntity")]
    public ListAssetStatusChangeEventsEntityAssetStatusChangeEventAssetStatusChangeSourceEntityTypeResponseBody? SourceEntity { get; set; }

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
