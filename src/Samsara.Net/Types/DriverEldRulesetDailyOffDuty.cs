using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<DriverEldRulesetDailyOffDuty>))]
public enum DriverEldRulesetDailyOffDuty
{
    [EnumMember(Value = "Canada South")]
    CanadaSouth,

    [EnumMember(Value = "Canada North")]
    CanadaNorth,
}
