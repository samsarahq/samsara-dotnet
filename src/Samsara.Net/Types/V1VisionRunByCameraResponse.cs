using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[Serializable]
public record V1VisionRunByCameraResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("cameraId")]
    public long? CameraId { get; set; }

    [JsonPropertyName("endedAtMs")]
    public long? EndedAtMs { get; set; }

    [JsonPropertyName("inspectionResults")]
    public IEnumerable<V1VisionRunByCameraResponseInspectionResults>? InspectionResults { get; set; }

    [JsonPropertyName("isOngoing")]
    public bool? IsOngoing { get; set; }

    [JsonPropertyName("program")]
    public V1VisionRunByCameraResponseProgram? Program { get; set; }

    [JsonPropertyName("runSummary")]
    public V1VisionRunByCameraResponseRunSummary? RunSummary { get; set; }

    [JsonPropertyName("startedAtMs")]
    public long? StartedAtMs { get; set; }

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
