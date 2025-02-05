using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record AssetsOnRouteLinkConfigObject
{
    /// <summary>
    /// Samsara ID of the recurring route.
    /// </summary>
    [JsonPropertyName("recurringRouteId")]
    public required string RecurringRouteId { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
