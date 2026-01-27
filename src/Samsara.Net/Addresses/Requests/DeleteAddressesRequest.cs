using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Addresses;

[Serializable]
public record DeleteAddressesRequest
{
    /// <summary>
    /// ID of the Address. This can either be the Samsara-provided ID or an external ID. External IDs are customer-specified key-value pairs created in the POST or PATCH requests of this resource. To specify an external ID as part of a path parameter, use the following format: `key:value`. For example, `crmId:abc123`
    /// </summary>
    [JsonIgnore]
    public required string Id { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
