using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// The trigger type specific details. Only the field that corresponds to the trigger type is filled in.
/// </summary>
public record TriggerParamsObjectRequestBody
{
    [JsonPropertyName("ambientTemperature")]
    public AmbientTemperatureDetailsObjectRequestBody? AmbientTemperature { get; set; }

    [JsonPropertyName("cellSignalLoss")]
    public CellSignalLossDetailsObjectRequestBody? CellSignalLoss { get; set; }

    [JsonPropertyName("defLevel")]
    public DefLevelTriggerDetailsObjectRequestBody? DefLevel { get; set; }

    [JsonPropertyName("deviceMovement")]
    public DeviceMovementTriggerDetailsObjectRequestBody? DeviceMovement { get; set; }

    [JsonPropertyName("documentSubmitted")]
    public DriverDocumentSubmittedDetailsObjectRequestBody? DocumentSubmitted { get; set; }

    [JsonPropertyName("dvirSubmittedDevice")]
    public DvirSubmittedDeviceTriggerDetailsObjectRequestBody? DvirSubmittedDevice { get; set; }

    [JsonPropertyName("engineIdle")]
    public EngineIdleTriggerDetailsObjectRequestBody? EngineIdle { get; set; }

    [JsonPropertyName("engineOff")]
    public EngineOffDetailsObjectRequestBody? EngineOff { get; set; }

    [JsonPropertyName("engineOn")]
    public EngineOnDetailsObjectRequestBody? EngineOn { get; set; }

    [JsonPropertyName("fuelLevel")]
    public FuelLevelTriggerDetailsObjectRequestBody? FuelLevel { get; set; }

    [JsonPropertyName("gatewayDisconnected")]
    public GatewayDisconnectedDetailsObjectRequestBody? GatewayDisconnected { get; set; }

    [JsonPropertyName("gatewayUnplugged")]
    public GatewayUnpluggedTriggerDetailsObjectRequestBody? GatewayUnplugged { get; set; }

    [JsonPropertyName("geofenceEntry")]
    public GeofenceEntryTriggerDetailsObjectRequestBody? GeofenceEntry { get; set; }

    [JsonPropertyName("geofenceExit")]
    public GeofenceExitTriggerDetailsObjectRequestBody? GeofenceExit { get; set; }

    [JsonPropertyName("gpsSignalLoss")]
    public GpsSignalLossDetailsObjectRequestBody? GpsSignalLoss { get; set; }

    [JsonPropertyName("harshEvent")]
    public HarshEventTriggerDetailsObjectRequestBody? HarshEvent { get; set; }

    [JsonPropertyName("hosViolation")]
    public HosViolationTriggerDetailsObjectRequestBody? HosViolation { get; set; }

    [JsonPropertyName("insideGeofence")]
    public InsideGeofenceTriggerDetailsObjectRequestBody? InsideGeofence { get; set; }

    [JsonPropertyName("outOfRoute")]
    public OutOfRouteDetailsObjectRequestBody? OutOfRoute { get; set; }

    [JsonPropertyName("outsideGeofence")]
    public OutsideGeofenceTriggerDetailsObjectRequestBody? OutsideGeofence { get; set; }

    [JsonPropertyName("panicButton")]
    public PanicButtonDetailsObjectRequestBody? PanicButton { get; set; }

    [JsonPropertyName("routeStopEstimatedArrival")]
    public RouteStopEstimatedArrivalDetailsObjectRequestBody? RouteStopEstimatedArrival { get; set; }

    [JsonPropertyName("scheduledMaintenance")]
    public ScheduledMaintenanceTriggerDetailsObjectRequestBody? ScheduledMaintenance { get; set; }

    [JsonPropertyName("scheduledMaintenanceByEngineHours")]
    public ScheduledMaintenanceByEngineHoursDetailsObjectRequestBody? ScheduledMaintenanceByEngineHours { get; set; }

    [JsonPropertyName("scheduledMaintenanceOdometer")]
    public ScheduledMaintenanceOdometerTriggerDetailsObjectRequestBody? ScheduledMaintenanceOdometer { get; set; }

    [JsonPropertyName("speed")]
    public SpeedTriggerDetailsObjectRequestBody? Speed { get; set; }

    [JsonPropertyName("suddenFuelLevelDrop")]
    public SuddenFuelLevelDropTriggerDetailsObjectRequestBody? SuddenFuelLevelDrop { get; set; }

    [JsonPropertyName("suddenFuelLevelRise")]
    public SuddenFuelLevelRiseTriggerDetailsObjectRequestBody? SuddenFuelLevelRise { get; set; }

    [JsonPropertyName("tireFaultCode")]
    public TireFaultCodeDetailsObjectRequestBody? TireFaultCode { get; set; }

    [JsonPropertyName("trainingAssignmentNearDueDate")]
    public TrainingAssignmentNearDueDateTriggerDetailsObjectRequestBody? TrainingAssignmentNearDueDate { get; set; }

    [JsonPropertyName("unassignedDriving")]
    public UnassignedDrivingTriggerDetailsObjectRequestBody? UnassignedDriving { get; set; }

    [JsonPropertyName("vehicleBatteryVoltage")]
    public VehicleBatterVoltageDetailsObjectRequestBody? VehicleBatteryVoltage { get; set; }

    [JsonPropertyName("vehicleFaultCode")]
    public VehicleFaultCodeDetailsObjectRequestBody? VehicleFaultCode { get; set; }

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
