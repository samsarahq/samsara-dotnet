using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// One asset matched to a recall.
/// </summary>
[Serializable]
public record MatchedRecallAssetResponseObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// ID of the matched asset.
    /// </summary>
    [JsonPropertyName("assetId")]
    public required string AssetId { get; set; }

    /// <summary>
    /// Whether the association is current (`matched`) or retained after the match ended (`matchEnded`). Defaults to `unknown` when the state is not recognized.  Valid values: `matched`, `matchEnded`, `unknown`
    /// </summary>
    [JsonPropertyName("matchState")]
    public required MatchedRecallAssetResponseObjectResponseBodyMatchState MatchState { get; set; }

    /// <summary>
    /// Unique ID of the recall. For NHTSA recalls, this is the campaign number.
    /// </summary>
    [JsonPropertyName("recallId")]
    public required string RecallId { get; set; }

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
