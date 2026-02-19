using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Routes;

[Serializable]
public record FetchRouteRequest
{
    /// <summary>
    /// A comma-separated list of additional fields to include in the response. Valid values: `stops.actualDistanceMeters`
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> Include { get; set; } = new List<string>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
