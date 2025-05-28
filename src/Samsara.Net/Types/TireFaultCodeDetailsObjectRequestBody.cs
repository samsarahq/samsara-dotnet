using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Details specific to Tire Fault Code. At least one fault code or fault code group must be selected.
/// </summary>
public record TireFaultCodeDetailsObjectRequestBody
{
    /// <summary>
    /// If true then alert over pressure, under pressure, across axle fault, or leak detected fault codes. Defaults to false.
    /// </summary>
    [JsonPropertyName("hasCautionaryTireFaultCodes")]
    public bool? HasCautionaryTireFaultCodes { get; set; }

    /// <summary>
    /// If true then alert over temperature or extreme pressure over or under fault codes. Defaults to false.
    /// </summary>
    [JsonPropertyName("hasCriticalTireFaultCodes")]
    public bool? HasCriticalTireFaultCodes { get; set; }

    /// <summary>
    /// The tire manufacturer.  Valid values: `MANUFACTURER_BENDIX`, `MANUFACTURER_CONTINENTAL`, `MANUFACTURER_DORAN`, `MANUFACTURER_HENDRICKSON`, `MANUFACTURER_INVALID`, `MANUFACTURER_PRESSURE_PRO`, `MANUFACTURER_UNIVERSAL_J1939`, `MANUFACTURER_UNIVERSAL_R141`
    /// </summary>
    [JsonPropertyName("manufacturer")]
    public required TireFaultCodeDetailsObjectRequestBodyManufacturer Manufacturer { get; set; }

    /// <summary>
    /// The list of specific tire fault codes to be alerted on.
    /// </summary>
    [JsonPropertyName("specificTireFaultCodes")]
    public IEnumerable<TireFaultCodeDetailsObjectRequestBodySpecificTireFaultCodesItem>? SpecificTireFaultCodes { get; set; }

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
