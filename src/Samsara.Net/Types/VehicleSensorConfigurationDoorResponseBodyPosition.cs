using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<VehicleSensorConfigurationDoorResponseBodyPosition>))]
public enum VehicleSensorConfigurationDoorResponseBodyPosition
{
    [EnumMember(Value = "back")]
    Back,

    [EnumMember(Value = "left")]
    Left,

    [EnumMember(Value = "right")]
    Right,
}
