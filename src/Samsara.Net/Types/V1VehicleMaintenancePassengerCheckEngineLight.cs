using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1VehicleMaintenancePassengerCheckEngineLight
{
    [JsonPropertyName("isOn")]
    public bool? IsOn { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
