using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Active J1939D1 statuses of a device.
/// </summary>
public record J1939D1StatusDataPoint
{
    [JsonPropertyName("time")]
    public string? Time { get; set; }

    /// <summary>
    /// List of active statuses.
    /// </summary>
    [JsonPropertyName("value")]
    public IEnumerable<J1939D1StatusDataPointValue>? Value { get; set; }

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
