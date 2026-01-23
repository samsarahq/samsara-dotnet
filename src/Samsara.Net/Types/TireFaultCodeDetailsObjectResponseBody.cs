using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Details specific to Tire Fault Code. At least one fault code or fault code group must be selected.
/// </summary>
[Serializable]
public record TireFaultCodeDetailsObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

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
    public required TireFaultCodeDetailsObjectResponseBodyManufacturer Manufacturer { get; set; }

    /// <summary>
    /// The list of specific tire fault codes to be alerted on.
    /// </summary>
    [JsonPropertyName("specificTireFaultCodes")]
    public IEnumerable<TireFaultCodeDetailsObjectResponseBodySpecificTireFaultCodesItem>? SpecificTireFaultCodes { get; set; }

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
