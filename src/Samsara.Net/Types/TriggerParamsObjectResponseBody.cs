using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// The trigger type specific details. Only the field that corresponds to the trigger type is filled in.
/// </summary>
public record TriggerParamsObjectResponseBody
{
    [JsonPropertyName("ambientTemperature")]
    public AmbientTemperatureDetailsObjectResponseBody? AmbientTemperature { get; set; }

    [JsonPropertyName("cellSignalLoss")]
    public CellSignalLossDetailsObjectResponseBody? CellSignalLoss { get; set; }

    [JsonPropertyName("defLevel")]
    public DefLevelTriggerDetailsObjectResponseBody? DefLevel { get; set; }

    [JsonPropertyName("deviceMovement")]
    public DeviceMovementTriggerDetailsObjectResponseBody? DeviceMovement { get; set; }

    [JsonPropertyName("documentSubmitted")]
    public DriverDocumentSubmittedDetailsObjectResponseBody? DocumentSubmitted { get; set; }

    [JsonPropertyName("dvirSubmittedDevice")]
    public DvirSubmittedDeviceTriggerDetailsObjectResponseBody? DvirSubmittedDevice { get; set; }

    [JsonPropertyName("engineIdle")]
    public EngineIdleTriggerDetailsObjectResponseBody? EngineIdle { get; set; }

    [JsonPropertyName("engineOff")]
    public EngineOffDetailsObjectResponseBody? EngineOff { get; set; }

    [JsonPropertyName("engineOn")]
    public EngineOnDetailsObjectResponseBody? EngineOn { get; set; }

    [JsonPropertyName("fuelLevel")]
    public FuelLevelTriggerDetailsObjectResponseBody? FuelLevel { get; set; }

    [JsonPropertyName("gatewayDisconnected")]
    public GatewayDisconnectedDetailsObjectResponseBody? GatewayDisconnected { get; set; }

    [JsonPropertyName("gatewayUnplugged")]
    public GatewayUnpluggedTriggerDetailsObjectResponseBody? GatewayUnplugged { get; set; }

    [JsonPropertyName("geofenceEntry")]
    public GeofenceEntryTriggerDetailsObjectResponseBody? GeofenceEntry { get; set; }

    [JsonPropertyName("geofenceExit")]
    public GeofenceExitTriggerDetailsObjectResponseBody? GeofenceExit { get; set; }

    [JsonPropertyName("gpsSignalLoss")]
    public GpsSignalLossDetailsObjectResponseBody? GpsSignalLoss { get; set; }

    [JsonPropertyName("harshEvent")]
    public HarshEventTriggerDetailsObjectResponseBody? HarshEvent { get; set; }

    [JsonPropertyName("hosViolation")]
    public HosViolationTriggerDetailsObjectResponseBody? HosViolation { get; set; }

    [JsonPropertyName("insideGeofence")]
    public InsideGeofenceTriggerDetailsObjectResponseBody? InsideGeofence { get; set; }

    [JsonPropertyName("outOfRoute")]
    public OutOfRouteDetailsObjectResponseBody? OutOfRoute { get; set; }

    [JsonPropertyName("outsideGeofence")]
    public OutsideGeofenceTriggerDetailsObjectResponseBody? OutsideGeofence { get; set; }

    [JsonPropertyName("panicButton")]
    public PanicButtonDetailsObjectResponseBody? PanicButton { get; set; }

    [JsonPropertyName("routeStopEstimatedArrival")]
    public RouteStopEstimatedArrivalDetailsObjectResponseBody? RouteStopEstimatedArrival { get; set; }

    [JsonPropertyName("scheduledMaintenance")]
    public ScheduledMaintenanceTriggerDetailsObjectResponseBody? ScheduledMaintenance { get; set; }

    [JsonPropertyName("scheduledMaintenanceByEngineHours")]
    public ScheduledMaintenanceByEngineHoursDetailsObjectResponseBody? ScheduledMaintenanceByEngineHours { get; set; }

    [JsonPropertyName("scheduledMaintenanceOdometer")]
    public ScheduledMaintenanceOdometerTriggerDetailsObjectResponseBody? ScheduledMaintenanceOdometer { get; set; }

    [JsonPropertyName("speed")]
    public SpeedTriggerDetailsObjectResponseBody? Speed { get; set; }

    [JsonPropertyName("tireFaultCode")]
    public TireFaultCodeDetailsObjectResponseBody? TireFaultCode { get; set; }

    [JsonPropertyName("trainingAssignmentNearDueDate")]
    public TrainingAssignmentNearDueDateTriggerDetailsObjectResponseBody? TrainingAssignmentNearDueDate { get; set; }

    [JsonPropertyName("unassignedDriving")]
    public UnassignedDrivingTriggerDetailsObjectResponseBody? UnassignedDriving { get; set; }

    [JsonPropertyName("vehicleBatteryVoltage")]
    public VehicleBatterVoltageDetailsObjectResponseBody? VehicleBatteryVoltage { get; set; }

    [JsonPropertyName("vehicleFaultCode")]
    public VehicleFaultCodeDetailsObjectResponseBody? VehicleFaultCode { get; set; }

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
