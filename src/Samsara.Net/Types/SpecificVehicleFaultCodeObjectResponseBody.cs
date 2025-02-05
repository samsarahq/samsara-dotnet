using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record SpecificVehicleFaultCodeObjectResponseBody
{
    /// <summary>
    /// The specific fault code name.
    /// </summary>
    [JsonPropertyName("faultCode")]
    public required string FaultCode { get; set; }

    /// <summary>
    /// The specific fault code type.  Valid values: `INVALID_FAULT_CODE_TYPE`, `J1939_DTC`, `J1939_SPN`, `PASSENGER_DTC`
    /// </summary>
    [JsonPropertyName("type")]
    public required SpecificVehicleFaultCodeObjectResponseBodyType Type { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
