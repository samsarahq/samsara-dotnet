using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Configuration details specific to the 'By Location' Live Sharing Link.
/// </summary>
public record AssetsNearLocationLinkConfigObject
{
    /// <summary>
    /// ID of the address. Can be either a unique Samsara ID or an external ID for the address.
    /// </summary>
    [JsonPropertyName("addressId")]
    public required string AddressId { get; set; }

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
