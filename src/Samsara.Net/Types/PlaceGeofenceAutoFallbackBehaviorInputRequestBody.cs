using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Action when auto-geofencing finds no matching candidate after filtering.
/// </summary>
[Serializable]
public record PlaceGeofenceAutoFallbackBehaviorInputRequestBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Fallback action: fail (default) or circle.  Valid values: `fail`, `circle`
    /// </summary>
    [JsonPropertyName("behaviorType")]
    public PlaceGeofenceAutoFallbackBehaviorInputRequestBodyBehaviorType? BehaviorType { get; set; }

    [JsonPropertyName("circle")]
    public PlaceGeofenceAutoFallbackCircleInputRequestBody? Circle { get; set; }

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
