using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// The outcome of a single gateway-to-device pairing. The `previousDevice` and `displacedGateway` fields describe the state of those entities immediately before this pairing was applied -- they identify the side-effects of the operation, not their post-pairing state.
/// </summary>
[Serializable]
public record PairGatewayResultObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("device")]
    public required PairResultDeviceObjectResponseBody Device { get; set; }

    [JsonPropertyName("displacedGateway")]
    public PairResultGatewayObjectResponseBody? DisplacedGateway { get; set; }

    [JsonPropertyName("gateway")]
    public required PairResultGatewayObjectResponseBody Gateway { get; set; }

    [JsonPropertyName("previousDevice")]
    public PairResultDeviceObjectResponseBody? PreviousDevice { get; set; }

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
