using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Object representing the granular details of the condition. These details will vary depending on the condition.
/// </summary>
[Serializable]
public record WorkflowIncidentDetailsObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("ambientTemperature")]
    public AmbientTemperatureResponseBody? AmbientTemperature { get; set; }

    [JsonPropertyName("cameraConnectorDisconected")]
    public CameraConnectorDisconectedResponseBody? CameraConnectorDisconected { get; set; }

    [JsonPropertyName("cameraStreamIssue")]
    public CameraStreamIssueResponseBody? CameraStreamIssue { get; set; }

    [JsonPropertyName("cellSignalLoss")]
    public CellSignalLossResponseBody? CellSignalLoss { get; set; }

    [JsonPropertyName("cloudBackupUploadIssue")]
    public CloudBackupUploadIssueResponseBody? CloudBackupUploadIssue { get; set; }

    [JsonPropertyName("dashcamDisconnected")]
    public DashcamDisconnectedResponseBody? DashcamDisconnected { get; set; }

    [JsonPropertyName("dataInputValue")]
    public DataInputValueResponseBody? DataInputValue { get; set; }

    [JsonPropertyName("deviceMovement")]
    public DeviceMovementDataResponseBody? DeviceMovement { get; set; }

    [JsonPropertyName("deviceMovementStopped")]
    public DeviceMovementStoppedDataResponseBody? DeviceMovementStopped { get; set; }

    [JsonPropertyName("doorOpen")]
    public DoorOpenResponseBody? DoorOpen { get; set; }

    [JsonPropertyName("driverAppSignIn")]
    public DriverAppSignInResponseBody? DriverAppSignIn { get; set; }

    [JsonPropertyName("driverAppSignOut")]
    public DriverAppSignOutResponseBody? DriverAppSignOut { get; set; }

    [JsonPropertyName("driverDocumentSubmitted")]
    public DriverDocumentSubmittedResponseBody? DriverDocumentSubmitted { get; set; }

    [JsonPropertyName("driverMessageReceived")]
    public DriverMessageReceivedResponseBody? DriverMessageReceived { get; set; }

    [JsonPropertyName("driverMessageSent")]
    public DriverMessageSentResponseBody? DriverMessageSent { get; set; }

    [JsonPropertyName("driverRecorded")]
    public DriverRecordedResponseBody? DriverRecorded { get; set; }

    [JsonPropertyName("dvirSubmittedDevice")]
    public WorkflowDvirSubmittedResponseObjectResponseBody? DvirSubmittedDevice { get; set; }

    [JsonPropertyName("engineIdle")]
    public EngineIdleDataResponseBody? EngineIdle { get; set; }

    [JsonPropertyName("engineOff")]
    public EngineOffResponseBody? EngineOff { get; set; }

    [JsonPropertyName("engineOn")]
    public EngineOnResponseBody? EngineOn { get; set; }

    [JsonPropertyName("formSubmitted")]
    public FormSubmittedResponseBody? FormSubmitted { get; set; }

    [JsonPropertyName("formUpdated")]
    public FormUpdatedResponseBody? FormUpdated { get; set; }

    [JsonPropertyName("fuelLevelPercentage")]
    public FuelLevelPercentageResponseBody? FuelLevelPercentage { get; set; }

    [JsonPropertyName("gatewayDisconnected")]
    public GatewayDisconnectedResponseBody? GatewayDisconnected { get; set; }

    [JsonPropertyName("gatewayUnplugged")]
    public GatewayWithVehicleTinyResponseResponseBody? GatewayUnplugged { get; set; }

    [JsonPropertyName("geofenceEntry")]
    public WorkflowGeofenceEventResponseObjectResponseBody? GeofenceEntry { get; set; }

    [JsonPropertyName("geofenceExit")]
    public WorkflowGeofenceEventResponseObjectResponseBody? GeofenceExit { get; set; }

    [JsonPropertyName("gpsSignalLoss")]
    public GpsSignalLossResponseBody? GpsSignalLoss { get; set; }

    [JsonPropertyName("harshEvent")]
    public HarshEventDataResponseBody? HarshEvent { get; set; }

    [JsonPropertyName("hosViolation")]
    public HosViolationDataResponseBody? HosViolation { get; set; }

    [JsonPropertyName("inactivity")]
    public InactivityResponseBody? Inactivity { get; set; }

    [JsonPropertyName("insideGeofence")]
    public InsideGeofenceDataResponseBody? InsideGeofence { get; set; }

    [JsonPropertyName("issueCreated")]
    public IssueCreatedResponseBody? IssueCreated { get; set; }

    [JsonPropertyName("jammingDetected")]
    public JammingDetectedResponseBody? JammingDetected { get; set; }

    [JsonPropertyName("missingDvirPastDue")]
    public MissingDvirPastDueResponseBody? MissingDvirPastDue { get; set; }

    [JsonPropertyName("motionDetected")]
    public MotionDetectedResponseBody? MotionDetected { get; set; }

    [JsonPropertyName("outOfRoute")]
    public OutOfRouteResponseBody? OutOfRoute { get; set; }

    [JsonPropertyName("outsideGeofence")]
    public OutsideGeofenceDataResponseBody? OutsideGeofence { get; set; }

    [JsonPropertyName("panicButton")]
    public PanicButtonResponseBody? PanicButton { get; set; }

    [JsonPropertyName("personDetected")]
    public PersonDetectedResponseBody? PersonDetected { get; set; }

    [JsonPropertyName("reading")]
    public ReadingTriggerDetailsResponseBody? Reading { get; set; }

    [JsonPropertyName("reeferTemperature")]
    public ReeferTemperatureResponseBody? ReeferTemperature { get; set; }

    [JsonPropertyName("routeStopArrival")]
    public RouteStopDetailsObjectResponseBody? RouteStopArrival { get; set; }

    [JsonPropertyName("routeStopDeparture")]
    public RouteStopDetailsObjectResponseBody? RouteStopDeparture { get; set; }

    [JsonPropertyName("routeStopETA")]
    public RouteStopEtaResponseBody? RouteStopEta { get; set; }

    [JsonPropertyName("scheduledMaintenance")]
    public ScheduledMaintenanceDataResponseBody? ScheduledMaintenance { get; set; }

    [JsonPropertyName("scheduledMaintenanceByEngineHours")]
    public ScheduledMaintenanceByEngineHoursResponseBody? ScheduledMaintenanceByEngineHours { get; set; }

    [JsonPropertyName("scheduledMaintenanceOdometer")]
    public ScheduledMaintenanceOdometerDataResponseBody? ScheduledMaintenanceOdometer { get; set; }

    [JsonPropertyName("severeSpeeding")]
    public SevereSpeedingStartedResponseObjectResponseBody? SevereSpeeding { get; set; }

    [JsonPropertyName("siteGatewayDisconnected")]
    public SiteGatewayDisconnectedResponseBody? SiteGatewayDisconnected { get; set; }

    [JsonPropertyName("speed")]
    public SpeedDataResponseBody? Speed { get; set; }

    [JsonPropertyName("suddenFuelLevelDrop")]
    public SuddenFuelLevelDropResponseBody? SuddenFuelLevelDrop { get; set; }

    [JsonPropertyName("suddenFuelLevelRise")]
    public SuddenFuelLevelRiseResponseBody? SuddenFuelLevelRise { get; set; }

    [JsonPropertyName("tamperingDetected")]
    public TamperingDetectedResponseBody? TamperingDetected { get; set; }

    [JsonPropertyName("tireFaults")]
    public TireFaultsResponseBody? TireFaults { get; set; }

    [JsonPropertyName("unassignedDriving")]
    public UnassignedDrivingDataResponseBody? UnassignedDriving { get; set; }

    [JsonPropertyName("vehicleBatteryVoltage")]
    public VehicleBatteryVoltageResponseBody? VehicleBatteryVoltage { get; set; }

    [JsonPropertyName("vehicleDefLevelPercentage")]
    public VehicleDefLevelPercentageResponseBody? VehicleDefLevelPercentage { get; set; }

    [JsonPropertyName("vehicleDetected")]
    public VehicleDetectedResponseBody? VehicleDetected { get; set; }

    [JsonPropertyName("vehicleFaults")]
    public VehicleFaultsResponseBody? VehicleFaults { get; set; }

    [JsonPropertyName("workerSafetySos")]
    public WorkerSafetySosDataResponseBody? WorkerSafetySos { get; set; }

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
