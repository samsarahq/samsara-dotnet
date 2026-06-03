using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record GetVoiceSessionsRequest
{
    /// <summary>
    /// Required, comma-separated list of voice session IDs to fetch full details for. Up to 100 session IDs per call. IDs that are not found are omitted from the response.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> Ids { get; set; } = new List<string>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
