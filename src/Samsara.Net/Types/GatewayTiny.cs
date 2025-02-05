using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record GatewayTiny
{
    /// <summary>
    /// The gateway model
    /// </summary>
    [JsonPropertyName("model")]
    public string? Model { get; set; }

    /// <summary>
    /// The serial number of the gateway.
    /// </summary>
    [JsonPropertyName("serial")]
    public string? Serial { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
