using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Legacy;

[JsonConverter(
    typeof(EnumSerializer<LegacyGetDriversVehicleAssignmentsRequestDriverActivationStatus>)
)]
public enum LegacyGetDriversVehicleAssignmentsRequestDriverActivationStatus
{
    [EnumMember(Value = "active")]
    Active,

    [EnumMember(Value = "deactivated")]
    Deactivated,
}
