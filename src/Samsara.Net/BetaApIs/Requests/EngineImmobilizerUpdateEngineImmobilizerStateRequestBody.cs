using System.Text.Json.Serialization;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record EngineImmobilizerUpdateEngineImmobilizerStateRequestBody
{
    /// <summary>
    /// Vehicle ID
    /// </summary>
    [JsonIgnore]
    public required long Id { get; set; }

    /// <summary>
    /// A list of relay states. If a relay is omitted, its state won't be updated. If the list is empty, a 400 bad request status code will be returned. If there are multiple states for the same relay, a 400 bad request status code will be returned.
    /// </summary>
    [JsonPropertyName("relayStates")]
    public IEnumerable<UpdateEngineImmobilizerRelayStateRequestBodyRequestBody> RelayStates { get; set; } =
        new List<UpdateEngineImmobilizerRelayStateRequestBodyRequestBody>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
