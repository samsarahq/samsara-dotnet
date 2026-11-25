using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record EntityAssetStatusesServiceUpdateAssetStatusRequestBody
{
    /// <summary>
    /// Unique identifier for the AssetStatus record.
    /// </summary>
    [JsonIgnore]
    public required string Id { get; set; }

    /// <summary>
    /// Note on the most recent status change. On update, required when the status being entered requires a comment on entry, or the status being left requires a comment on exit.
    /// </summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>
    /// Stable ID of the status the asset is in. On update, the status to move the asset into.
    /// </summary>
    [JsonPropertyName("statusUuid")]
    public string? StatusUuid { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
