using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record EquipmentPatchEquipmentResponseBody
{
    [JsonPropertyName("data")]
    public required EquipmentWithAttributesResponseObjectResponseBody Data { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
