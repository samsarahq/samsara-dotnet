using System.Text.Json.Serialization;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record HubRouteTemplatesCreateHubRouteTemplateRequestBody
{
    [JsonPropertyName("defaultDepotEnd")]
    public CreateHubRouteTemplateDepotEndInputRequestBody? DefaultDepotEnd { get; set; }

    [JsonPropertyName("defaultDepotStart")]
    public CreateHubRouteTemplateDepotStartInputRequestBody? DefaultDepotStart { get; set; }

    /// <summary>
    /// Default start time in HH:MM format in the hub's local timezone (e.g. '08:00').
    /// </summary>
    [JsonPropertyName("defaultStartTimeOfDay")]
    public string? DefaultStartTimeOfDay { get; set; }

    /// <summary>
    /// The ID of the hub.
    /// </summary>
    [JsonPropertyName("hubId")]
    public required string HubId { get; set; }

    /// <summary>
    /// Stop locations referenced by external ID, in the order they should be visited.
    /// </summary>
    [JsonPropertyName("locationExternalIds")]
    public IEnumerable<string>? LocationExternalIds { get; set; }

    /// <summary>
    /// The name of the route template.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
