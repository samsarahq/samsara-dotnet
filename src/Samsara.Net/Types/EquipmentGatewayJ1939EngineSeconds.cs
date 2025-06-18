using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Engine seconds reading from the J1939/CAT cable.
/// </summary>
public record EquipmentGatewayJ1939EngineSeconds
{
    [JsonPropertyName("time")]
    public required string Time { get; set; }

    /// <summary>
    /// The number of seconds an engine has been running as detected via aux input 1 active state. Used in combination with an offset provided manually through the Samsara cloud dashboard. This is supported with the following hardware configurations: AG24/AG26/AG46P + APWR cable (Auxiliary engine configuration required) AG52/AG53 + BPWR/BEQP cable (Auxiliary engine configuration required).
    /// </summary>
    [JsonPropertyName("value")]
    public required int Value { get; set; }

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
