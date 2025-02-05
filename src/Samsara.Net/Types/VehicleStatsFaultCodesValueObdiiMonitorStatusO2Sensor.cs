using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<VehicleStatsFaultCodesValueObdiiMonitorStatusO2Sensor>))]
public enum VehicleStatsFaultCodesValueObdiiMonitorStatusO2Sensor
{
    [EnumMember(Value = "N")]
    N,

    [EnumMember(Value = "R")]
    R,

    [EnumMember(Value = "U")]
    U,
}
