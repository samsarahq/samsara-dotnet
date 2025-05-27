using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Drivers.VehicleAssignments;

[JsonConverter(typeof(EnumSerializer<VehicleAssignmentsListRequestDriverActivationStatus>))]
public enum VehicleAssignmentsListRequestDriverActivationStatus
{
    [EnumMember(Value = "active")]
    Active,

    [EnumMember(Value = "deactivated")]
    Deactivated,
}
