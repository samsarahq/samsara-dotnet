using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<VehicleResponseObjectResponseBodyVehicleRegulationMode>))]
public enum VehicleResponseObjectResponseBodyVehicleRegulationMode
{
    [EnumMember(Value = "regulated")]
    Regulated,

    [EnumMember(Value = "unregulated")]
    Unregulated,
}
