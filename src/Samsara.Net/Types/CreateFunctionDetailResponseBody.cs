using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Details of a newly created Function, including a URL for uploading the code package. After uploading, call the deploy endpoint to make the function runnable.
/// </summary>
[Serializable]
public record CreateFunctionDetailResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("codePackage")]
    public required FunctionCodePackageResponseBody CodePackage { get; set; }

    [JsonPropertyName("config")]
    public required FunctionConfigResponseBody Config { get; set; }

    /// <summary>
    /// RFC 3339 timestamp when the Function was created.
    /// </summary>
    [JsonPropertyName("createdAtTime")]
    public required DateTime CreatedAtTime { get; set; }

    /// <summary>
    /// Description of the Function.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("effects")]
    public required FunctionEffectsResponseBody Effects { get; set; }

    /// <summary>
    /// Epoch milliseconds of the last update. Use this value for optimistic locking in PATCH requests.
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
    /// A presigned PUT URL for uploading the function's code package. Valid for a limited time. After uploading, call `POST /functions/{name}/deploy` to make the function runnable.
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
