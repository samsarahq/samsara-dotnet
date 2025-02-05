using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record AempEquipmentGetAempEquipmentListResponseBody
{
    [JsonPropertyName("Fleet")]
    public required AempFleetListResponseBody Fleet { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
