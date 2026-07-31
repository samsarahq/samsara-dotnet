using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.PreviewApIs;

[Serializable]
public record GetOrdersRequest
{
    /// <summary>
    /// Comma-separated Samsara order UUIDs or external ID tokens. Maximum 100.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> OrderIds { get; set; } = new List<string>();

    /// <summary>
    /// Include external IDs in returned orders.
    /// </summary>
    [JsonIgnore]
    public bool? IncludeExternalIds { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
