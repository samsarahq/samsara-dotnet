using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record HubRouteTemplatesUpdateHubRouteTemplateRequestBody
{
    /// <summary>
    /// The unique identifier of the route template to update.
    /// </summary>
    [JsonIgnore]
    public required string Id { get; set; }

    /// <summary>
    /// The external identifier of the default end depot, as configured in the hub. Send an empty string to clear it.
    /// </summary>
    [JsonPropertyName("defaultDepotEndExternalId")]
    public string? DefaultDepotEndExternalId { get; set; }

    /// <summary>
    /// The external identifier of the default start depot, as configured in the hub. Send an empty string to clear it.
    /// </summary>
    [JsonPropertyName("defaultDepotStartExternalId")]
    public string? DefaultDepotStartExternalId { get; set; }

    /// <summary>
    /// Default start time in HH:MM format in the hub's local timezone (e.g. '08:00'). Send an empty string to clear it.
    /// </summary>
    [JsonPropertyName("defaultStartTimeOfDay")]
    public string? DefaultStartTimeOfDay { get; set; }

    /// <summary>
    /// Full replacement of the ordered stop list, referenced by external ID. Omit to leave stops unchanged; send an empty array to clear all stops.
    /// </summary>
    [JsonPropertyName("locationsByExternalIds")]
    public IEnumerable<string>? LocationsByExternalIds { get; set; }

    /// <summary>
    /// The new name of the route template.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
