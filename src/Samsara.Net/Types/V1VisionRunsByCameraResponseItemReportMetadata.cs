using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[Serializable]
public record V1VisionRunsByCameraResponseItemReportMetadata : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("itemsPerMinute")]
    public float? ItemsPerMinute { get; set; }

    [JsonPropertyName("noReadCount")]
    public long? NoReadCount { get; set; }

    [JsonPropertyName("rejectCount")]
    public long? RejectCount { get; set; }

    [JsonPropertyName("successCount")]
    public long? SuccessCount { get; set; }

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
