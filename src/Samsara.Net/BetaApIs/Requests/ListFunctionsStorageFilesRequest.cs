using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record ListFunctionsStorageFilesRequest
{
    /// <summary>
    /// If specified, this should be the endCursor value from the previous page of results. When present, this request will return the next page of results that occur immediately after the previous page of results.
    /// </summary>
    [JsonIgnore]
    public string? After { get; set; }

    /// <summary>
    /// The maximum number of files to return per page.
    /// </summary>
    [JsonIgnore]
    public long? Limit { get; set; }

    /// <summary>
    /// If true, include presigned download URLs for each file.
    /// </summary>
    [JsonIgnore]
    public bool? IncludeDownloadUrls { get; set; }

    /// <summary>
    /// If true, include presigned upload URLs for each file. Requires write permission.
    /// </summary>
    [JsonIgnore]
    public bool? IncludeUploadUrls { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
