using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record DefectVehicleResponseResponseBody
{
    /// <summary>
    /// A map of external ids
    /// </summary>
    [JsonPropertyName("externalIds")]
    public Dictionary<string, string>? ExternalIds { get; set; }

    /// <summary>
    /// ID of the vehicle
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
