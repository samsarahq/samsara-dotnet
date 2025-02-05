using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.DriverVehicleAssignments;

[JsonConverter(
    typeof(EnumSerializer<DriverVehicleAssignmentsGetDriverVehicleAssignmentsRequestFilterBy>)
)]
public enum DriverVehicleAssignmentsGetDriverVehicleAssignmentsRequestFilterBy
{
    [EnumMember(Value = "drivers")]
    Drivers,

    [EnumMember(Value = "vehicles")]
    Vehicles,
}
