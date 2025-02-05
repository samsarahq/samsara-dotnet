using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(EnumSerializer<DriversVehicleAssignmentsObjectResponseBodyDriverActivationStatus>)
)]
public enum DriversVehicleAssignmentsObjectResponseBodyDriverActivationStatus
{
    [EnumMember(Value = "active")]
    Active,

    [EnumMember(Value = "deactivated")]
    Deactivated,
}
