using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Details specific to Worker Safety SOS.
/// </summary>
[Serializable]
public record WorkerSafetySosDataResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("driver")]
    public AlertObjectDriverResponseBody? Driver { get; set; }

    [JsonPropertyName("location")]
    public EventLocationResponseBody? Location { get; set; }

    /// <summary>
    /// The source of the SOS signal.  Valid values: `appSos`, `noResponseCheckIn`, `wearableSos`, `fallDetected`
    /// </summary>
    [JsonPropertyName("sourceType")]
    public required WorkerSafetySosDataResponseBodySourceType SourceType { get; set; }

    [JsonPropertyName("vehicle")]
    public AlertObjectVehicleResponseBody? Vehicle { get; set; }

    /// <summary>
    /// URL of the Worker Safety incident in the cloud dashboard.
    /// </summary>
    [JsonPropertyName("workerSafetyIncidentUrl")]
    public required string WorkerSafetyIncidentUrl { get; set; }

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
