using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<DriverEldRulesetRestBreak>))]
public enum DriverEldRulesetRestBreak
{
    [EnumMember(Value = "Property (off-duty/sleeper)")]
    PropertyOffDutySleeper,

    [EnumMember(Value = "Explosives/HazMat (on-duty)")]
    ExplosivesHazMatOnDuty,
}
