using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<VehicleSensorConfigurationDoorPosition>))]
public enum VehicleSensorConfigurationDoorPosition
{
    [EnumMember(Value = "Position_Left")]
    PositionLeft,

    [EnumMember(Value = "Position_Right")]
    PositionRight,
}
