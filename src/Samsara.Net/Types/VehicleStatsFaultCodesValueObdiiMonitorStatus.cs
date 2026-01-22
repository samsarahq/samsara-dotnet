using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Readings from engine sensors
/// </summary>
[Serializable]
public record VehicleStatsFaultCodesValueObdiiMonitorStatus : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Enum of monitor status:
    /// -U: Unsupported
    /// -N: Not Complete
    /// -R: Complete
    /// </summary>
    [JsonPropertyName("catalyst")]
    public VehicleStatsFaultCodesValueObdiiMonitorStatusCatalyst? Catalyst { get; set; }

    /// <summary>
    /// Enum of monitor status:
    /// -U: Unsupported
    /// -N: Not Complete
    /// -R: Complete
    /// </summary>
    [JsonPropertyName("comprehensive")]
    public VehicleStatsFaultCodesValueObdiiMonitorStatusComprehensive? Comprehensive { get; set; }

    /// <summary>
    /// Enum of monitor status:
    /// -U: Unsupported
    /// -N: Not Complete
    /// -R: Complete
    /// </summary>
    [JsonPropertyName("egr")]
    public VehicleStatsFaultCodesValueObdiiMonitorStatusEgr? Egr { get; set; }

    /// <summary>
    /// Enum of monitor status:
    /// -U: Unsupported
    /// -N: Not Complete
    /// -R: Complete
    /// </summary>
    [JsonPropertyName("evapSystem")]
    public VehicleStatsFaultCodesValueObdiiMonitorStatusEvapSystem? EvapSystem { get; set; }

    /// <summary>
    /// Enum of monitor status:
    /// -U: Unsupported
    /// -N: Not Complete
    /// -R: Complete
    /// </summary>
    [JsonPropertyName("fuel")]
    public VehicleStatsFaultCodesValueObdiiMonitorStatusFuel? Fuel { get; set; }

    /// <summary>
    /// Enum of monitor status:
    /// -U: Unsupported
    /// -N: Not Complete
    /// -R: Complete
    /// </summary>
    [JsonPropertyName("heatedCatalyst")]
    public VehicleStatsFaultCodesValueObdiiMonitorStatusHeatedCatalyst? HeatedCatalyst { get; set; }

    /// <summary>
    /// Enum of monitor status:
    /// -U: Unsupported
    /// -N: Not Complete
    /// -R: Complete
    /// </summary>
    [JsonPropertyName("heatedO2Sensor")]
    public VehicleStatsFaultCodesValueObdiiMonitorStatusHeatedO2Sensor? HeatedO2Sensor { get; set; }

    /// <summary>
    /// Enum of monitor status:
    /// -U: Unsupported
    /// -N: Not Complete
    /// -R: Complete
    /// </summary>
    [JsonPropertyName("isoSaeReserved")]
    public VehicleStatsFaultCodesValueObdiiMonitorStatusIsoSaeReserved? IsoSaeReserved { get; set; }

    /// <summary>
    /// Enum of monitor status:
    /// -U: Unsupported
    /// -N: Not Complete
    /// -R: Complete
    /// </summary>
    [JsonPropertyName("misfire")]
    public VehicleStatsFaultCodesValueObdiiMonitorStatusMisfire? Misfire { get; set; }

    /// <summary>
    /// Count of the number of sensors reporting N: Not Complete
    /// </summary>
    [JsonPropertyName("notReadyCount")]
    public long? NotReadyCount { get; set; }

    /// <summary>
    /// Enum of monitor status:
    /// -U: Unsupported
    /// -N: Not Complete
    /// -R: Complete
    /// </summary>
    [JsonPropertyName("o2Sensor")]
    public VehicleStatsFaultCodesValueObdiiMonitorStatusO2Sensor? O2Sensor { get; set; }

    /// <summary>
    /// Enum of monitor status:
    /// -U: Unsupported
    /// -N: Not Complete
    /// -R: Complete
    /// </summary>
    [JsonPropertyName("secondaryAir")]
    public VehicleStatsFaultCodesValueObdiiMonitorStatusSecondaryAir? SecondaryAir { get; set; }

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
