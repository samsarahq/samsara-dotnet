using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.PreviewApIs;

[Serializable]
public record DeleteOrderRequest
{
    /// <summary>
    /// One Samsara order UUID or external ID token.
    /// </summary>
    [JsonIgnore]
    public required string OrderId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
