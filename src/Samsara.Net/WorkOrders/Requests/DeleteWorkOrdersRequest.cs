using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.WorkOrders;

[Serializable]
public record DeleteWorkOrdersRequest
{
    /// <summary>
    /// The unique id of the work order.
    /// </summary>
    [JsonIgnore]
    public required string Id { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
