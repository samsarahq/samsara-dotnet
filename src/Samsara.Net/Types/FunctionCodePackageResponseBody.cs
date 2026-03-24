using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Code package status for the Function.
/// </summary>
[Serializable]
public record FunctionCodePackageResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// A presigned GET URL for downloading the function's current code package. Present only when code has been uploaded.
    /// </summary>
    [JsonPropertyName("downloadGetUrl")]
    public string? DownloadGetUrl { get; set; }

    /// <summary>
    /// Status of the code package.  Valid values: `unknown`, `pendingUpload`, `uploaded`, `deployed`
    /// </summary>
    [JsonPropertyName("status")]
    public required FunctionCodePackageResponseBodyStatus Status { get; set; }

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
