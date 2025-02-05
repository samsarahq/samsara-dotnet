using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record VehicleStatsFaultCodesValueJ1939VendorSpecificFields
{
    /// <summary>
    /// The DTC description, if available.
    /// </summary>
    [JsonPropertyName("dtcDescription")]
    public string? DtcDescription { get; set; }

    /// <summary>
    /// A link to vendor repair instructions, if available.
    /// </summary>
    [JsonPropertyName("repairInstructionsUrl")]
    public string? RepairInstructionsUrl { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
