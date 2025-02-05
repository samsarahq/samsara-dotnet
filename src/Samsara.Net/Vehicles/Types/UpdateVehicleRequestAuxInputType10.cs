using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Vehicles;

[JsonConverter(typeof(EnumSerializer<UpdateVehicleRequestAuxInputType10>))]
public enum UpdateVehicleRequestAuxInputType10
{
    [EnumMember(Value = "none")]
    None,

    [EnumMember(Value = "emergencyLights")]
    EmergencyLights,

    [EnumMember(Value = "emergencyAlarm")]
    EmergencyAlarm,

    [EnumMember(Value = "stopPaddle")]
    StopPaddle,

    [EnumMember(Value = "powerTakeOff")]
    PowerTakeOff,

    [EnumMember(Value = "plow")]
    Plow,

    [EnumMember(Value = "sweeper")]
    Sweeper,

    [EnumMember(Value = "salter")]
    Salter,

    [EnumMember(Value = "reefer")]
    Reefer,

    [EnumMember(Value = "door")]
    Door,

    [EnumMember(Value = "boom")]
    Boom,

    [EnumMember(Value = "auxiliaryEngine")]
    AuxiliaryEngine,

    [EnumMember(Value = "generator")]
    Generator,

    [EnumMember(Value = "eightWayLights")]
    EightWayLights,

    [EnumMember(Value = "panicButton")]
    PanicButton,

    [EnumMember(Value = "privacyButton")]
    PrivacyButton,

    [EnumMember(Value = "frontAxleDrive")]
    FrontAxleDrive,

    [EnumMember(Value = "weightSensor")]
    WeightSensor,

    [EnumMember(Value = "other")]
    Other,

    [EnumMember(Value = "secondaryFuelSource")]
    SecondaryFuelSource,

    [EnumMember(Value = "ecuPowerTakeOff")]
    EcuPowerTakeOff,
}
