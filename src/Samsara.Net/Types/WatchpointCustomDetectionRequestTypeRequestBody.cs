using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Condition to detect in new Watchpoint observations.
/// </summary>
[Serializable]
public record WatchpointCustomDetectionRequestTypeRequestBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Additional criteria narrowing the supported detection. Defaults to empty.
    /// </summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }

    /// <summary>
    /// Supported detection type. Required; there is no default.  Valid values: `workZone`, `stoppedVehicle`, `vehicleCollision`, `roadObstruction`, `roadClosure`, `roadDefect`, `trafficSignalFault`
    /// </summary>
    [JsonPropertyName("type")]
    public required WatchpointCustomDetectionRequestTypeRequestBodyType Type { get; set; }

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
