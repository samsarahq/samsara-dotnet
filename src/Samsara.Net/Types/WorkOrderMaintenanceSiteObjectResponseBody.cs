using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// The maintenance site (inventory location) where the work is performed.
/// </summary>
[Serializable]
public record WorkOrderMaintenanceSiteObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Display name of the maintenance site.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// External identifiers for the linked Place. Populated only when the request sets `includeExternalIds=true`.
    /// </summary>
    [JsonPropertyName("placeExternalIds")]
    public Dictionary<string, string>? PlaceExternalIds { get; set; }

    /// <summary>
    /// ID of the Place linked to this maintenance site. Joinable against the Places API. Omitted if the maintenance site is not linked to a place.
    /// </summary>
    [JsonPropertyName("placeId")]
    public string? PlaceId { get; set; }

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
