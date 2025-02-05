using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record AssetsNearLocationLinkConfigObject
{
    /// <summary>
    /// ID of the address. Can be either a unique Samsara ID or an external ID for the address.
    /// </summary>
    [JsonPropertyName("addressId")]
    public required string AddressId { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
