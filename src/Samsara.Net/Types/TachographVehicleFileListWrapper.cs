using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record TachographVehicleFileListWrapper
{
    [JsonPropertyName("files")]
    public IEnumerable<TachographVehicleFile>? Files { get; set; }

    [JsonPropertyName("vehicle")]
    public VehicleTinyResponse? Vehicle { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
