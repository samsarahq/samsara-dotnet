using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Details of an updated Function, including a URL for uploading a new code package. After uploading, call the deploy endpoint for the changes to be applied.
/// </summary>
[Serializable]
public record PatchFunctionDetailResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Epoch milliseconds of the last update. Use this value in subsequent patch requests.
    /// </summary>
    [JsonPropertyName("lastUpdateTimestampMs")]
    public required long LastUpdateTimestampMs { get; set; }

    /// <summary>
    /// Name of the Function.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// RFC 3339 timestamp when the Function was last updated.
    /// </summary>
    [JsonPropertyName("updatedAtTime")]
    public required DateTime UpdatedAtTime { get; set; }

    /// <summary>
    /// A presigned PUT URL for uploading the function's code package. Valid for a limited time. After uploading, call `POST /functions/{name}/deploy` for the changes to be applied.
    /// </summary>
    [JsonPropertyName("uploadPutUrl")]
    public required string UploadPutUrl { get; set; }

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
