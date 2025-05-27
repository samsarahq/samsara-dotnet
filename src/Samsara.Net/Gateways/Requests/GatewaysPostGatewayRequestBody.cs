using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Gateways;

public record GatewaysPostGatewayRequestBody
{
    /// <summary>
    /// Gateway serial number
    /// </summary>
    [JsonPropertyName("serial")]
    public required string Serial { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
