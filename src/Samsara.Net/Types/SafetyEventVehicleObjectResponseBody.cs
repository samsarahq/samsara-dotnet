using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record SafetyEventVehicleObjectResponseBody
{
    /// <summary>
    /// ID of the vehicle.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
