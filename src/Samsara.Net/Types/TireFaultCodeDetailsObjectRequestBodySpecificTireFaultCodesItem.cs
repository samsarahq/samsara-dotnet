using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(EnumSerializer<TireFaultCodeDetailsObjectRequestBodySpecificTireFaultCodesItem>)
)]
public enum TireFaultCodeDetailsObjectRequestBodySpecificTireFaultCodesItem
{
    [EnumMember(Value = "TIRE_ALERT_ACROSS_AXLE_FAULT")]
    TireAlertAcrossAxleFault,

    [EnumMember(Value = "TIRE_ALERT_EXTREME_OVER_PRESSURE")]
    TireAlertExtremeOverPressure,

    [EnumMember(Value = "TIRE_ALERT_EXTREME_UNDER_PRESSURE")]
    TireAlertExtremeUnderPressure,

    [EnumMember(Value = "TIRE_ALERT_INVALID")]
    TireAlertInvalid,

    [EnumMember(Value = "TIRE_ALERT_LEAK_DETECTED")]
    TireAlertLeakDetected,

    [EnumMember(Value = "TIRE_ALERT_OVER_PRESSURE")]
    TireAlertOverPressure,

    [EnumMember(Value = "TIRE_ALERT_OVER_TEMPERATURE")]
    TireAlertOverTemperature,

    [EnumMember(Value = "TIRE_ALERT_SENSOR_DEFECT")]
    TireAlertSensorDefect,

    [EnumMember(Value = "TIRE_ALERT_SENSOR_LOOSE_OR_FLIPPED")]
    TireAlertSensorLooseOrFlipped,

    [EnumMember(Value = "TIRE_ALERT_SENSOR_LOW_BATTERY")]
    TireAlertSensorLowBattery,

    [EnumMember(Value = "TIRE_ALERT_SENSOR_MISSING")]
    TireAlertSensorMissing,

    [EnumMember(Value = "TIRE_ALERT_UNDER_PRESSURE")]
    TireAlertUnderPressure,
}
