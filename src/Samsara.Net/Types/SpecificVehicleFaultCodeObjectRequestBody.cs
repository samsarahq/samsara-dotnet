using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A specific vehicle fault code.
/// </summary>
public record SpecificVehicleFaultCodeObjectRequestBody
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
    public required SpecificVehicleFaultCodeObjectRequestBodyType Type { get; set; }

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
