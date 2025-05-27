using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.LiveShares;

public record LiveSharesDeleteRequest
{
    /// <summary>
    /// Unique identifier for the Live Sharing Link.
    /// </summary>
    [JsonIgnore]
    public required string Id { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
