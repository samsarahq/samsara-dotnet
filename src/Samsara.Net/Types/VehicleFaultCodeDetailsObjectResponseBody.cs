using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Details specific to Vehicle Fault Code. At least one fault code or fault code group must be selected.
/// </summary>
public record VehicleFaultCodeDetailsObjectResponseBody
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
    public IEnumerable<SpecificVehicleFaultCodeObjectResponseBody>? SpecificFaultCodes { get; set; }

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
