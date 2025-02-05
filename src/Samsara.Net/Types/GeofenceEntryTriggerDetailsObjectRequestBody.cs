using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record GeofenceEntryTriggerDetailsObjectRequestBody
{
    [JsonPropertyName("location")]
    public required LocationObjectRequestBody Location { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
