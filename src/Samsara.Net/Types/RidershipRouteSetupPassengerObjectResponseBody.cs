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
    /// Routing API stop task ID for the passenger's drop-off. Omitted when no drop-off stop is assigned.
    /// </summary>
    [JsonPropertyName("dropOffStopId")]
    public string? DropOffStopId { get; set; }

    /// <summary>
    /// The Samsara UUID of the passenger.
    /// </summary>
    [JsonPropertyName("passengerId")]
    public required string PassengerId { get; set; }

    /// <summary>
    /// Routing API stop task ID for the passenger's pickup. Omitted when no pickup stop is assigned.
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
