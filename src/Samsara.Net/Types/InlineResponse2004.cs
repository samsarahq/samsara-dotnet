using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record InlineResponse2004
{
    [JsonPropertyName("vehicles")]
    public IEnumerable<V1VehicleMaintenance>? Vehicles { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
