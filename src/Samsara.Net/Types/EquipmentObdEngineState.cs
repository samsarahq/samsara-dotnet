using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Engine state reading from on-board diagnostics.
/// </summary>
public record EquipmentObdEngineState
{
    [JsonPropertyName("time")]
    public required string Time { get; set; }

    /// <summary>
    /// The state of the engine read from on-board diagnostics. Valid values: `Off`, `On`, `Idle`.
    /// </summary>
    [JsonPropertyName("value")]
    public required EquipmentObdEngineStateValue Value { get; set; }

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
