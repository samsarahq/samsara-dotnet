using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// The file outputs produced by a successfully completed job.
/// </summary>
public record IftaDetailJobOutputResponseBody
{
    /// <summary>
    /// When this file was created.
    /// </summary>
    [JsonPropertyName("createdAtTime")]
    public required string CreatedAtTime { get; set; }

    /// <summary>
    /// A url to download the generated file. The contents will be gzipped. This url has an expiration and will no longer be valid after expiration.
    /// </summary>
    [JsonPropertyName("downloadUrl")]
    public required string DownloadUrl { get; set; }

    /// <summary>
    /// The expiration time of this file's download url. Requesting this job again by ID will refresh the download urls, if expired.
    /// </summary>
    [JsonPropertyName("downloadUrlExpirationTime")]
    public required string DownloadUrlExpirationTime { get; set; }

    /// <summary>
    /// The name of this file.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// The number of records in this file.
    /// </summary>
    [JsonPropertyName("recordCount")]
    public required long RecordCount { get; set; }

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
