using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record EngineImmobilizerRelayStateResponseBody
{
    /// <summary>
    /// The ID of the relay  Valid values: `relay1`, `relay2`
    /// </summary>
    [JsonPropertyName("id")]
    public required EngineImmobilizerRelayStateResponseBodyId Id { get; set; }

    /// <summary>
    /// Whether the relay is open.
    /// </summary>
    [JsonPropertyName("isOpen")]
    public required bool IsOpen { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
