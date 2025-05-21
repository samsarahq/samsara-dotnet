using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1SensorHistoryResponseResults
{
    /// <summary>
    /// List of datapoints, one for each requested (sensor, field) pair.
    /// </summary>
    [JsonPropertyName("series")]
    public IEnumerable<long>? Series { get; set; }

    /// <summary>
    /// Timestamp in UNIX milliseconds.
    /// </summary>
    [JsonPropertyName("timeMs")]
    public int? TimeMs { get; set; }

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
