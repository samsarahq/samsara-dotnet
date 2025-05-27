using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A time-series of engine total idle time minutes. (Beta)
/// </summary>
public record EquipmentEngineTotalIdleTimeMinutes
{
    [JsonPropertyName("time")]
    public required string Time { get; set; }

    /// <summary>
    /// Total time in minutes that the engine has been idling since the device was installed. This value is calculated based on the time the engine has been running while the vehicle is not in motion.
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
