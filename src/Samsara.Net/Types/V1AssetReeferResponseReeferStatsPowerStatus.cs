using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1AssetReeferResponseReeferStatsPowerStatus
{
    /// <summary>
    /// Timestamp in Unix milliseconds since epoch.
    /// </summary>
    [JsonPropertyName("changedAtMs")]
    public long? ChangedAtMs { get; set; }

    /// <summary>
    /// Power status of the reefer. Valid values: `Off`, `Active`, `Active (Start/Stop)`, `Active (Continuous)`.
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

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
