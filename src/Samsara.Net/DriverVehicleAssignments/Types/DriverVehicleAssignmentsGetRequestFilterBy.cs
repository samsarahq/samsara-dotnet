using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.DriverVehicleAssignments;

[JsonConverter(typeof(EnumSerializer<DriverVehicleAssignmentsGetRequestFilterBy>))]
public enum DriverVehicleAssignmentsGetRequestFilterBy
{
    [EnumMember(Value = "drivers")]
    Drivers,

    [EnumMember(Value = "vehicles")]
    Vehicles,
}
