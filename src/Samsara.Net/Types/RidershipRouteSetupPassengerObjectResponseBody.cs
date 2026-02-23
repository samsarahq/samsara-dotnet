using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A passenger assignment within a route setup.
/// </summary>
[Serializable]
public record RidershipRouteSetupPassengerObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The stop ID for the passenger's drop-off.
    /// </summary>
    [JsonPropertyName("dropOffStopId")]
    public string? DropOffStopId { get; set; }

    /// <summary>
    /// The Samsara UUID of the passenger.
    /// </summary>
    [JsonPropertyName("passengerId")]
    public required string PassengerId { get; set; }

    /// <summary>
    /// The stop ID for the passenger's pick-up.
    /// </summary>
    [JsonPropertyName("pickUpStopId")]
    public string? PickUpStopId { get; set; }

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
