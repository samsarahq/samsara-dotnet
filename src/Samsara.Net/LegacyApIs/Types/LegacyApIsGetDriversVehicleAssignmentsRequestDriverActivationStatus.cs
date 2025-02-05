using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.LegacyApIs;

[JsonConverter(
    typeof(EnumSerializer<LegacyApIsGetDriversVehicleAssignmentsRequestDriverActivationStatus>)
)]
public enum LegacyApIsGetDriversVehicleAssignmentsRequestDriverActivationStatus
{
    [EnumMember(Value = "active")]
    Active,

    [EnumMember(Value = "deactivated")]
    Deactivated,
}
