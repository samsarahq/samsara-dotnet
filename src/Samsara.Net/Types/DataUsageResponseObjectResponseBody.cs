using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// An object containing information about the gateway data usage in mb for the last 30 days.
/// </summary>
public record DataUsageResponseObjectResponseBody
{
    /// <summary>
    /// Celluar data usage in bytes.
    /// </summary>
    [JsonPropertyName("cellularDataUsageBytes")]
    public long? CellularDataUsageBytes { get; set; }

    /// <summary>
    /// Wifi hotspot data usage in bytes.
    /// </summary>
    [JsonPropertyName("hotspotUsageBytes")]
    public long? HotspotUsageBytes { get; set; }

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
