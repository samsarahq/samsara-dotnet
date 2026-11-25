using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record GetRecallMatchedAssetsRequest
{
    /// <summary>
    /// Unique ID of the recall. For NHTSA recalls, this is the campaign number. Maximum 64 characters.
    /// </summary>
    [JsonIgnore]
    public required string RecallId { get; set; }

    /// <summary>
    /// If specified, this should be the endCursor value from the previous page of results. When present, this request will return the next page of results that occur immediately after the previous page of results.
    /// </summary>
    [JsonIgnore]
    public string? After { get; set; }

    /// <summary>
    /// Sort order for the page. Defaults to `assetId`. `makeModelYearAsc` and `makeModelYearDesc` require match-store reads.  Valid values: `assetId`, `makeModelYearAsc`, `makeModelYearDesc`
    /// </summary>
    [JsonIgnore]
    public GetRecallMatchedAssetsRequestOrder? Order { get; set; }

    /// <summary>
    /// When true, include retained ended associations (`matchEnded`). Defaults to true.
    /// </summary>
    [JsonIgnore]
    public bool? IncludeEnded { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
