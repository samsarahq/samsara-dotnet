using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Readings from engine sensors
/// </summary>
public record VehicleStatsFaultCodesValueObdiiMonitorStatus
{
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
    public int? NotReadyCount { get; set; }

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
