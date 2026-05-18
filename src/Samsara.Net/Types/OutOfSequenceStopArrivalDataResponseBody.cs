using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Details specific to Out-of-Sequence Stop Arrival.
/// </summary>
[Serializable]
public record OutOfSequenceStopArrivalDataResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Name of the stop the driver actually arrived at.
    /// </summary>
    [JsonPropertyName("actualStopName")]
    public string? ActualStopName { get; set; }

    [JsonPropertyName("driver")]
    public AlertObjectDriverResponseBody? Driver { get; set; }

    /// <summary>
    /// Name of the stop the driver was expected to arrive at.
    /// </summary>
    [JsonPropertyName("expectedStopName")]
    public string? ExpectedStopName { get; set; }

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
