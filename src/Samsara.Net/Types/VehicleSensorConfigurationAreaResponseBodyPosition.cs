using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<VehicleSensorConfigurationAreaResponseBodyPosition>))]
public enum VehicleSensorConfigurationAreaResponseBodyPosition
{
    [EnumMember(Value = "back")]
    Back,

    [EnumMember(Value = "front")]
    Front,

    [EnumMember(Value = "middle")]
    Middle,
}
