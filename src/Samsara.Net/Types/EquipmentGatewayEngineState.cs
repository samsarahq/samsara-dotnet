using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Engine state reading from the aux/digio cable.
/// </summary>
public record EquipmentGatewayEngineState
{
    [JsonPropertyName("time")]
    public required string Time { get; set; }

    /// <summary>
    /// An approximation of engine state based on readings the AG26 receives from the aux/digio cable. Valid values: `Off`, `On`.
    /// </summary>
    [JsonPropertyName("value")]
    public required EquipmentGatewayEngineStateValue Value { get; set; }

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
