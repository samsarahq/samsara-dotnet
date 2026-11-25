using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Details specific to Trailer Assignment Mismatch.
/// </summary>
[Serializable]
public record VehicleTrailerMismatchDataResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Trailers the vehicle was associated with pulling in the incident metadata. An empty array means no trailer associations were recorded. Omitted when metadata or all referenced trailer details are unavailable.
    /// </summary>
    [JsonPropertyName("currentlyPullingTrailers")]
    public IEnumerable<AlertObjectTrailerResponseBody>? CurrentlyPullingTrailers { get; set; }

    [JsonPropertyName("driver")]
    public AlertObjectDriverResponseBody? Driver { get; set; }

    /// <summary>
    /// Trailers the driver selected in the incident metadata. An empty array means no trailers were selected. Omitted when metadata or all referenced trailer details are unavailable.
    /// </summary>
    [JsonPropertyName("driverSelectedTrailers")]
    public IEnumerable<AlertObjectTrailerResponseBody>? DriverSelectedTrailers { get; set; }

    [JsonPropertyName("vehicle")]
    public AlertObjectVehicleResponseBody? Vehicle { get; set; }

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
