using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1VehicleMaintenanceJ1939CheckEngineLight
{
    [JsonPropertyName("emissionsIsOn")]
    public bool? EmissionsIsOn { get; set; }

    [JsonPropertyName("protectIsOn")]
    public bool? ProtectIsOn { get; set; }

    [JsonPropertyName("stopIsOn")]
    public bool? StopIsOn { get; set; }

    [JsonPropertyName("warningIsOn")]
    public bool? WarningIsOn { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
