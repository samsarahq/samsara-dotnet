using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<AlertEventAlertConditionId>))]
public enum AlertEventAlertConditionId
{
    [EnumMember(Value = "DeviceHasVehicleFault")]
    DeviceHasVehicleFault,

    [EnumMember(Value = "DeviceUnplugged")]
    DeviceUnplugged,

    [EnumMember(Value = "HarshEvent")]
    HarshEvent,

    [EnumMember(Value = "DeviceLocationInsideGeofence")]
    DeviceLocationInsideGeofence,

    [EnumMember(Value = "DeviceLocationOutsideGeofence")]
    DeviceLocationOutsideGeofence,

    [EnumMember(Value = "DriverDocumentSubmitted")]
    DriverDocumentSubmitted,

    [EnumMember(Value = "DeviceSpeedAbove")]
    DeviceSpeedAbove,

    [EnumMember(Value = "DeviceSpeedAboveSpeedLimit")]
    DeviceSpeedAboveSpeedLimit,

    [EnumMember(Value = "DeviceMovement")]
    DeviceMovement,

    [EnumMember(Value = "EngineIdle")]
    EngineIdle,

    [EnumMember(Value = "BatteryLow")]
    BatteryLow,

    [EnumMember(Value = "DashcamDisconnected")]
    DashcamDisconnected,

    [EnumMember(Value = "HosViolation")]
    HosViolation,

    [EnumMember(Value = "VehicleFuelLevelBelow")]
    VehicleFuelLevelBelow,

    [EnumMember(Value = "TemperatureBelow")]
    TemperatureBelow,

    [EnumMember(Value = "TemperatureAbove")]
    TemperatureAbove,

    [EnumMember(Value = "HumidityBelow")]
    HumidityBelow,

    [EnumMember(Value = "HumidityAbove")]
    HumidityAbove,

    [EnumMember(Value = "DeviceDisconnect")]
    DeviceDisconnect,

    [EnumMember(Value = "BatteryVoltageBelow")]
    BatteryVoltageBelow,

    [EnumMember(Value = "DoorActivated")]
    DoorActivated,

    [EnumMember(Value = "DispatchRouteETAThreshold")]
    DispatchRouteEtaThreshold,

    [EnumMember(Value = "ReeferHasNewAlarm")]
    ReeferHasNewAlarm,

    [EnumMember(Value = "ReeferTemperatureAboveSetPoint")]
    ReeferTemperatureAboveSetPoint,

    [EnumMember(Value = "ReeferTemperatureBelowSetPoint")]
    ReeferTemperatureBelowSetPoint,

    [EnumMember(Value = "ScheduledMaintenanceDate")]
    ScheduledMaintenanceDate,

    [EnumMember(Value = "ScheduledMaintenanceEngineHours")]
    ScheduledMaintenanceEngineHours,

    [EnumMember(Value = "ScheduledMaintenanceOdometer")]
    ScheduledMaintenanceOdometer,

    [EnumMember(Value = "UnsafeDvir")]
    UnsafeDvir,

    [EnumMember(Value = "SafeDvirWithDefects")]
    SafeDvirWithDefects,

    [EnumMember(Value = "PanicButtonPressed")]
    PanicButtonPressed,
}
