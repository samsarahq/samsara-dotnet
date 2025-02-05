using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record OrganizationInfo
{
    [JsonPropertyName("carrierSettings")]
    public OrganizationInfoCarrierSettings? CarrierSettings { get; set; }

    /// <summary>
    /// ID of the organization.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Name of organization.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
