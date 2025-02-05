using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<VehicleResponseObjectResponseBodyVehicleType>))]
public enum VehicleResponseObjectResponseBodyVehicleType
{
    [EnumMember(Value = "unset")]
    Unset,

    [EnumMember(Value = "passenger")]
    Passenger,

    [EnumMember(Value = "truck")]
    Truck,

    [EnumMember(Value = "bus")]
    Bus,
}
