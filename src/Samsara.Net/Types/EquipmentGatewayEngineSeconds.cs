using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Engine seconds reading from the aux/digio cable.
/// </summary>
public record EquipmentGatewayEngineSeconds
{
    [JsonPropertyName("time")]
    public required string Time { get; set; }

    /// <summary>
    /// The number of seconds an engine has been running as detected via engine state. Used in combination with an offset provided manually through the Samsara cloud dashboard. Useful for when assets do not report engine hours over the J1939 network. The Engine Speed SPN must be available from the ECU for this parameter to properly calculate seconds. This is supported with the following hardware configurations: AG24/AG26 + AOPEN/A9PIN/ACT9/ACT14.
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
