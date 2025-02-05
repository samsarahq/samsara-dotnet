using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record GeofenceExitTriggerDetailsObjectResponseBody
{
    [JsonPropertyName("location")]
    public required LocationObjectResponseBody Location { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
