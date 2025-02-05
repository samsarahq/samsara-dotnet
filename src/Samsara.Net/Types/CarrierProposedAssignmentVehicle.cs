using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record CarrierProposedAssignmentVehicle
{
    /// <summary>
    /// The [external IDs](https://developers.samsara.com/docs/external-ids) for the given object.
    /// </summary>
    [JsonPropertyName("ExternalIds")]
    public Dictionary<string, string>? ExternalIds { get; set; }

    /// <summary>
    /// ID of the vehicle.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Name of the vehicle.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
