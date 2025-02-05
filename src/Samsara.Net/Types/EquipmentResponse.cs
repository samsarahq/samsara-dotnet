using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record EquipmentResponse
{
    [JsonPropertyName("data")]
    public required Equipment Data { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
