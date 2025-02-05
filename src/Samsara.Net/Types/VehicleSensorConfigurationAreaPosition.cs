using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<VehicleSensorConfigurationAreaPosition>))]
public enum VehicleSensorConfigurationAreaPosition
{
    [EnumMember(Value = "Position_Front")]
    PositionFront,

    [EnumMember(Value = "Position_Middle")]
    PositionMiddle,

    [EnumMember(Value = "Position_Back")]
    PositionBack,
}
