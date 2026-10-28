using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Configured condition detected in new Watchpoint observations.
/// </summary>
[Serializable]
public record WatchpointCustomDetectionResponseTypeResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Normalized customer criteria. Defaults to empty.
    /// </summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }

    /// <summary>
    /// Configured detection type. Returns unknown if the stored type is unsupported.  Valid values: `unknown`, `workZone`, `stoppedVehicle`, `vehicleCollision`, `roadObstruction`, `roadClosure`, `roadDefect`, `trafficSignalFault`
    /// </summary>
    [JsonPropertyName("type")]
    public required WatchpointCustomDetectionResponseTypeResponseBodyType Type { get; set; }

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
