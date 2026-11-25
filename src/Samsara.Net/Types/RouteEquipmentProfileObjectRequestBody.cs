using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Routing equipment profile association for a route.
/// </summary>
[Serializable]
public record RouteEquipmentProfileObjectRequestBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// ID of the hub that the equipment profile belongs to. Optional; only needed to disambiguate when an organization has multiple hubs with equipment profiles that share the same name. If provided, must match the equipment profile's own hub or the request is rejected.
    /// </summary>
    [JsonPropertyName("hubId")]
    public string? HubId { get; set; }

    /// <summary>
    /// ID of the routing equipment profile (e.g. a HAZMAT profile).
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

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
