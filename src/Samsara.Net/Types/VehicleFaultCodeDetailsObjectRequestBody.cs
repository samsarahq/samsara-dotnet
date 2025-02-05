using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record VehicleFaultCodeDetailsObjectRequestBody
{
    /// <summary>
    /// If true then alert on codes for less serious errors that do not warrant stopping. Defaults to false.
    /// </summary>
    [JsonPropertyName("hasAnyAmberWarningLampCodes")]
    public bool? HasAnyAmberWarningLampCodes { get; set; }

    /// <summary>
    /// If true this means that any code is alertable. Defaults to false.
    /// </summary>
    [JsonPropertyName("hasAnyFaultCodes")]
    public bool? HasAnyFaultCodes { get; set; }

    /// <summary>
    /// If true then alert on emission-related codes. Defaults to false.
    /// </summary>
    [JsonPropertyName("hasAnyMalfunctionIndicatorLampCodes")]
    public bool? HasAnyMalfunctionIndicatorLampCodes { get; set; }

    /// <summary>
    /// If true then alert on codes for non-electric vehicle parts. Defaults to false.
    /// </summary>
    [JsonPropertyName("hasAnyProtectionLampCodes")]
    public bool? HasAnyProtectionLampCodes { get; set; }

    /// <summary>
    /// If true then alert when the vehicle warrants stopping. Defaults to false.
    /// </summary>
    [JsonPropertyName("hasAnyRedStopLampCodes")]
    public bool? HasAnyRedStopLampCodes { get; set; }

    /// <summary>
    /// If true then alert when the ABS light is on. Defaults to false.
    /// </summary>
    [JsonPropertyName("hasAnyTrailerAbsLampCodes")]
    public bool? HasAnyTrailerAbsLampCodes { get; set; }

    /// <summary>
    /// The list of specific fault codes to be alerted on.
    /// </summary>
    [JsonPropertyName("specificFaultCodes")]
    public IEnumerable<SpecificVehicleFaultCodeObjectRequestBody>? SpecificFaultCodes { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
