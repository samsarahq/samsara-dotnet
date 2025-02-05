using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record OrganizationInfoCarrierSettings
{
    /// <summary>
    /// Carrier for a given organization.
    /// </summary>
    [JsonPropertyName("carrierName")]
    public string? CarrierName { get; set; }

    /// <summary>
    /// Carrier US DOT Number for the organization.
    /// </summary>
    [JsonPropertyName("dotNumber")]
    public long? DotNumber { get; set; }

    /// <summary>
    /// Main office address for a given organization.
    /// </summary>
    [JsonPropertyName("mainOfficeAddress")]
    public string? MainOfficeAddress { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
