using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1AssetsReeferReeferStatsPowerStatus
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
    public V1AssetsReeferReeferStatsPowerStatusStatus? Status { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
