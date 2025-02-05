using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<VehicleStatsFaultCodesValueObdiiMonitorStatusHeatedO2Sensor>))]
public enum VehicleStatsFaultCodesValueObdiiMonitorStatusHeatedO2Sensor
{
    [EnumMember(Value = "N")]
    N,

    [EnumMember(Value = "R")]
    R,

    [EnumMember(Value = "U")]
    U,
}
