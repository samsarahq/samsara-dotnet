using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Beta.Inputs;

[JsonConverter(typeof(EnumSerializer<InputsStreamRequestType>))]
public enum InputsStreamRequestType
{
    [EnumMember(Value = "auxInput1")]
    AuxInput1,

    [EnumMember(Value = "auxInput2")]
    AuxInput2,

    [EnumMember(Value = "auxInput3")]
    AuxInput3,

    [EnumMember(Value = "auxInput4")]
    AuxInput4,

    [EnumMember(Value = "auxInput5")]
    AuxInput5,

    [EnumMember(Value = "auxInput6")]
    AuxInput6,

    [EnumMember(Value = "auxInput7")]
    AuxInput7,

    [EnumMember(Value = "auxInput8")]
    AuxInput8,

    [EnumMember(Value = "auxInput9")]
    AuxInput9,

    [EnumMember(Value = "auxInput10")]
    AuxInput10,

    [EnumMember(Value = "auxInput11")]
    AuxInput11,

    [EnumMember(Value = "auxInput12")]
    AuxInput12,

    [EnumMember(Value = "auxInput13")]
    AuxInput13,

    [EnumMember(Value = "analogInput1Voltage")]
    AnalogInput1Voltage,

    [EnumMember(Value = "analogInput2Voltage")]
    AnalogInput2Voltage,

    [EnumMember(Value = "analogInput1Current")]
    AnalogInput1Current,

    [EnumMember(Value = "analogInput2Current")]
    AnalogInput2Current,

    [EnumMember(Value = "batteryVoltage")]
    BatteryVoltage,
}
