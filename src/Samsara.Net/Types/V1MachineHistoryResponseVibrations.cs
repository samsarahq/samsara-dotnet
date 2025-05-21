using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1MachineHistoryResponseVibrations
{
    [JsonPropertyName("X")]
    public double? X { get; set; }

    [JsonPropertyName("Y")]
    public double? Y { get; set; }

    [JsonPropertyName("Z")]
    public double? Z { get; set; }

    [JsonPropertyName("time")]
    public long? Time { get; set; }

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
