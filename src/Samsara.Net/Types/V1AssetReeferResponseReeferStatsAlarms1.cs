using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1AssetReeferResponseReeferStatsAlarms1
{
    [JsonPropertyName("alarms")]
    public IEnumerable<V1AssetReeferResponseReeferStatsAlarms>? Alarms { get; set; }

    /// <summary>
    /// Timestamp when the alarms were reported, in Unix milliseconds since epoch
    /// </summary>
    [JsonPropertyName("changedAtMs")]
    public long? ChangedAtMs { get; set; }

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
