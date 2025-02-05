using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Beta.Fleet;

[JsonConverter(typeof(EnumSerializer<FleetGetDriverEfficiencyRequestDriverActivationStatus>))]
public enum FleetGetDriverEfficiencyRequestDriverActivationStatus
{
    [EnumMember(Value = "active")]
    Active,

    [EnumMember(Value = "deactivated")]
    Deactivated,
}
