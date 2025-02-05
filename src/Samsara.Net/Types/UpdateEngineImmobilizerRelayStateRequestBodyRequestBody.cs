using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record UpdateEngineImmobilizerRelayStateRequestBodyRequestBody
{
    /// <summary>
    /// The ID of the relay  Valid values: `relay1`, `relay2`
    /// </summary>
    [JsonPropertyName("id")]
    public required UpdateEngineImmobilizerRelayStateRequestBodyRequestBodyId Id { get; set; }

    /// <summary>
    /// The desired state of the relay. Provide `true` to open the relay, or `false` to close the relay.
    /// </summary>
    [JsonPropertyName("isOpen")]
    public required bool IsOpen { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
