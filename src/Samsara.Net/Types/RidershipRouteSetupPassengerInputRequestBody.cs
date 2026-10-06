using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A passenger assignment for a route.
/// </summary>
[Serializable]
public record RidershipRouteSetupPassengerInputRequestBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Drop-off stop task ID from the Routing API, or an external ID such as `stopKey:stop-456`. Omit to leave the drop-off stop unspecified.
    /// </summary>
    [JsonPropertyName("dropOffStopId")]
    public string? DropOffStopId { get; set; }

    /// <summary>
    /// The Samsara UUID of the passenger, or an external ID in `key:value` format. For example, `student:STU-001`.
    /// </summary>
    [JsonPropertyName("passengerId")]
    public required string PassengerId { get; set; }

    /// <summary>
    /// Pickup stop task ID from the Routing API, or an external ID such as `stopKey:stop-123`. Omit to leave the pickup stop unspecified.
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
