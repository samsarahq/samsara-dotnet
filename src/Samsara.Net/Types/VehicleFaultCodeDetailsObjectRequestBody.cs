using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Details specific to Vehicle Fault Code. At least one fault code or fault code group must be selected.
/// </summary>
[Serializable]
public record VehicleFaultCodeDetailsObjectRequestBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

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
    /// The number of milliseconds the trigger needs to stay active before alerting.
    /// </summary>
    [JsonPropertyName("minDurationMilliseconds")]
    public long? MinDurationMilliseconds { get; set; }

    /// <summary>
    /// The list of specific fault codes to be alerted on.
    /// </summary>
    [JsonPropertyName("specificFaultCodes")]
    public IEnumerable<SpecificVehicleFaultCodeObjectRequestBody>? SpecificFaultCodes { get; set; }

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
