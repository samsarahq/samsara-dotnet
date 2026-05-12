using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Details specific to Route Stop Early/Late Arrival.
/// </summary>
[Serializable]
public record RouteStopEarlyLateArrivalDataResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Whether the vehicle arrived early or late relative to the scheduled time.  Valid values: `early`, `late`
    /// </summary>
    [JsonPropertyName("arrivalStatus")]
    public RouteStopEarlyLateArrivalDataResponseBodyArrivalStatus? ArrivalStatus { get; set; }

    /// <summary>
    /// The absolute deviation in minutes from the scheduled arrival time. Always positive. Use arrivalStatus to determine if early or late.
    /// </summary>
    [JsonPropertyName("deviationMinutes")]
    public long? DeviationMinutes { get; set; }

    [JsonPropertyName("driver")]
    public AlertObjectDriverResponseBody? Driver { get; set; }

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
