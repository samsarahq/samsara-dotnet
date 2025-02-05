using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<UsDriverRulesetOverrideRestbreak>))]
public enum UsDriverRulesetOverrideRestbreak
{
    [EnumMember(Value = "Property (off-duty/sleeper)")]
    PropertyOffDutySleeper,

    [EnumMember(Value = "California Mealbreak (off-duty/sleeper)")]
    CaliforniaMealbreakOffDutySleeper,

    [EnumMember(Value = "None")]
    None,
}
