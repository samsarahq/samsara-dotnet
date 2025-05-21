using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A request object to update a relay state.
/// </summary>
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

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
